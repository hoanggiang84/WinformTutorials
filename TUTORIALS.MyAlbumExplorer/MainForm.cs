using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TUTORIALS.Library;
using TUTORIALS.Library.Forms;

namespace TUTORIALS.MyAlbumExplorer
{
    internal enum AlbumColumn
    {
        Name,
        Title,
        Password,
        Size
    }

    internal enum PhotoColumn
    {
        Caption,
        Taken,
        Photographer,
        FileName
    }

    public partial class MainForm : Form
    {
        // Acording to imageLists
        private const int PhotoIndex = 0;
        private const int AlbumIndex = 1;
        private const int ErrorIndex = 2;
        private const int SelectedPhotoIndex = 5;
        private const int AlbumDirectoryIndex = 4;
        private const int SelectedAlbumIndex = 3;

        private MyListViewComparer _comparer;
        private bool _albumShown = true;
        private PhotoAlbum _album;
        private static Pen borderPen = new Pen(SystemColors.WindowFrame);

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var v = new Version(Application.ProductVersion);
            Text = string.Format("MyAlbumExplorer {0:#}.{1:#}", v.Major, v.Minor);

            _comparer = new MyListViewComparer(listViewMain);
            listViewMain.ListViewItemSorter = _comparer;
            listViewMain.Sorting = SortOrder.Ascending;

            LoadAlbumData(PhotoAlbum.DefaultDir);
            InitTreeData();
        }

        private void InitTreeData()
        {
            treeViewMain.BeginUpdate();
            treeViewMain.Nodes.Clear();

            var defaultRoot = new TreeNode("Default Albums", AlbumDirectoryIndex, AlbumDirectoryIndex)
                                  {Tag = PhotoAlbum.DefaultDir};
            treeViewMain.Nodes.Add(defaultRoot);
            treeViewMain.SelectedNode = defaultRoot;

            foreach (var s in Directory.GetFiles(PhotoAlbum.DefaultDir,"*.abm"))
            {
                var baseName = Path.GetFileNameWithoutExtension(s);
                var albumNode = new TreeNode(baseName, new[] {new TreeNode("child")}) {Tag = s};
                defaultRoot.Nodes.Add(albumNode);
            }
            treeViewMain.EndUpdate();
        }

        private void LoadAlbumData(string dir)
        {
            listViewMain.Clear();
            
            _comparer.CurrentAlbum = null;
            _albumShown = true;
            if (_album != null)
            {
                _album.Dispose();
                _album = null;
            }

            listViewMain.Columns.Add("Name", 80, HorizontalAlignment.Left);
            listViewMain.Columns.Add("Title", 100, HorizontalAlignment.Left);
            listViewMain.Columns.Add("Pwd", 40, HorizontalAlignment.Center);
            listViewMain.Columns.Add("Size", 40, HorizontalAlignment.Right);

            var albumFiles = Directory.GetFiles(dir, "*.abm");
            foreach (string s in albumFiles)
            {
                var album = OpenAlbum(s);
                var item = new ListViewItem
                               {
                                   Text = Path.GetFileNameWithoutExtension(s),
                                   
                               };
                if(album != null)
                {
                    item.Tag = album.FileName;
                    item.ImageIndex = AlbumIndex;
                    item.SubItems.Add(album.Title);
                    bool hasPwd = !string.IsNullOrEmpty(album.Password);
                    item.SubItems.Add(hasPwd ? "y" : "n");
                    item.SubItems.Add(album.Count.ToString());
                }
                else
                {
                    item.ImageIndex = ErrorIndex;
                    item.SubItems.Add(item.Text);
                    item.SubItems.Add("?"); 
                    item.SubItems.Add("0");
                }
                listViewMain.Items.Add(item);
            }
        }

        private PhotoAlbum OpenAlbum(string file)
        {
            var album = new PhotoAlbum();
            try
            {
                 album.Open(file);
            }
            catch (Exception)
            {
                return null;
            }
            return album;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void viewToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            var v = listViewMain.View;
            largeIconsToolStripMenuItem.Checked = (v == View.LargeIcon);
            smallIconsToolStripMenuItem.Checked = (v == View.SmallIcon);
            listToolStripMenuItem.Checked = (v == View.List);
            detailsToolStripMenuItem.Checked = (v == View.Details);
            if (_albumShown && listViewMain.SelectedItems.Count > 0)
                photosToolStripMenuItem.Enabled = true;
            else
                photosToolStripMenuItem.Enabled = false;
        }

        private void largeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewMain.View = View.LargeIcon;
        }

        private void smallIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewMain.View = View.SmallIcon;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewMain.View = View.List;
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewMain.View = View.Details;
        }

        private void listViewMain_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            var prevOrder = listViewMain.Sorting;
            listViewMain.Sorting = SortOrder.None;

            if(e.Column == _comparer.SortColumn)
            {
                listViewMain.Sorting = (prevOrder == SortOrder.Ascending) ? SortOrder.Descending : SortOrder.Ascending;
            }
            else
            {
                _comparer.SortColumn = e.Column;
                listViewMain.Sorting = SortOrder.Ascending;
            }
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeViewMain.Focused)
            {
                var node = treeViewMain.SelectedNode;
                var file = node.Tag as string;
                if(node == null || node.Parent == null || file == null)
                    return;
                
                if(Path.GetExtension(file) == ".abm")
                    DisplayAlbumProperties(node);
                else
                    DisplayPhotoProperties(node);
            }
            else if (pictureBoxMain.Focused)
            {
                var node = treeViewMain.SelectedNode;
                if(node!= null)
                    DisplayPhotoProperties(node);
            }
            else if(listViewMain.SelectedItems.Count>0)
            {
                var item = listViewMain.SelectedItems[0];

                if (_albumShown)
                    DisplayAlbumProperties(item);
                else
                    DisplayPhotoProperties(item);
            }
        }

        private void DisplayPhotoProperties(object obj)
        {
            var item = obj as ListViewItem;
            var node = obj as TreeNode;

            int index = 0;
            if(item!=null && item.Tag is int)
            {
                index = (int)item.Tag;
            }
            else if(node != null)
            {
                index = node.Index;
            }

            _album.CurrentPosition = index;

            using (var dlg = new PhotoEditDlg(_album))
            {
                if(dlg.ShowDialog()==DialogResult.OK)
                {
                    try
                    {
                        _album.Save(_album.FileName);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Unable to save changes to photos in album.");
                    }
                }

                TreeNode baseNode = null;
                if(item!=null)
                {
                    LoadPhotoData(_album);
                    baseNode = treeViewMain.SelectedNode;
                }
                else if(node!=null)
                {
                    baseNode = node.Parent;
                }

                if(baseNode!= null)
                {
                    foreach (TreeNode n in baseNode.Nodes)
                    {
                        n.Text = _album[n.Index].Caption;
                    }
                }
            }
        }

        private void DisplayAlbumProperties(object obj)
        {
            var item = obj as ListViewItem;
            var node = obj as TreeNode;

            PhotoAlbum album = null;
            if(item!=null)
            {
                var fileName = item.Tag as string;
                if (fileName != null)
                    album = OpenAlbum(fileName);
            }
            else if(node!=null)
            {
                album = OpenTreeAlbum(node);
            }

            if(album == null)
            {
                MessageBox.Show("The properties for this album cannot be displayed.");
                return;
            }

            using (var dlg = new AlbumEditDlg(album))
            {
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        album.Save();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Unable to save changes to album.");
                        return;
                    }

                    if(item!=null)
                    {
                        item.SubItems[(int)AlbumColumn.Title].Text = album.Title;
                        item.SubItems[(int)AlbumColumn.Password].Text = string.IsNullOrEmpty(album.Password) ? "n" : "y";
                    }
                }
            }
            album.Dispose();
        }

        private void editNametoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(treeViewMain.Focused)
            {
                if(treeViewMain.SelectedNode != null)
                    treeViewMain.SelectedNode.BeginEdit();
            }
            else if(listViewMain.SelectedItems.Count > 1)
                listViewMain.SelectedItems[0].BeginEdit();
        }

        private void listViewMain_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.F2)
            {
                if(listViewMain.SelectedItems.Count == 1)
                {
                    listViewMain.SelectedItems[0].BeginEdit();
                    e.Handled = true;
                }
            }
        }

        private void listViewMain_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if(e.Label == null)
            {
                // Edit cancelled by the user
                e.CancelEdit = true;
                return;
            }

            var item = listViewMain.Items[e.Item];
            if (_albumShown)
                e.CancelEdit = !UpdateAlbumName(e.Label, item);
            else 
                e.CancelEdit = !UpdatePhotoCaption(e.Label, item);
        }

        private bool UpdatePhotoCaption(string caption, object obj)
        {
            var item = obj as ListViewItem;
            var node = obj as TreeNode;

            int index = -1;
            if(item != null 
                && item.Tag is int)
            {
                index = (int) item.Tag;
                node = FindNode(_album[index].FileName, false);
            }
            else if(node!=null)
            {
                index = node.Index;
            }

            if(caption.Length == 0 || index < 0)
            {
                MessageBox.Show("Invalid caption value.");
                return false;
            }

            _album[index].Caption = caption;

            if(item != null && node != null)
            {
                node.Text = caption;
            }

            try
            {
                _album.Save(_album.FileName);
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to save new caption to album file.");
            }
            return true;
        }

        private bool UpdateAlbumName(string newName, ListViewItem item)
        {
            var fileName = item.Tag as string;
            var newFileName = RenameFile(fileName, newName, ".abm");
            if(newFileName == null)
            {
                MessageBox.Show("Unable to rename album to this name.");
                return false;
            }

            item.Tag = newFileName;
            return true;
        }

        private bool UpdateAlbumName(string newName, TreeNode node)
        {
            var fileName = node.Tag as string;
            var newFileName = RenameFile(fileName, newName, ".abm");
            if (newFileName == null)
            {
                MessageBox.Show("Unable to rename album to this name.");
                return false;
            }
            node.Tag = newFileName;
            return true;

        }

        private string RenameFile(string origFile, string newBase, string ext)
        {
            var fileName = Path.GetDirectoryName(origFile) + "\\" + newBase;
            var newFile = Path.ChangeExtension(fileName, ext);
            try
            {
                File.Move(origFile, newFile);
                return newFile;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void listViewMain_ItemActivate(object sender, EventArgs e)
        {
            if(listViewMain.SelectedItems.Count > 0)
            {
                var item = listViewMain.SelectedItems[0];
                var fileName = item.Tag as string;

                if(_albumShown)
                {
                    fileName = item.Tag as string;
                }
                else if(item.Tag is int)
                {
                    var index = (int) item.Tag;
                    fileName = _album[index].FileName;
                }

                if(fileName == null)
                {
                    MessageBox.Show("This item cannot be opened.");
                    return;
                }

                var node = FindNode(fileName, true);
                if(node!=null)
                {
                    node.EnsureVisible();
                    treeViewMain.SelectedNode = node;
                }
            }
        }

        private void LoadPhotoData(PhotoAlbum album)
        {
            listViewMain.Clear();
            if(_album != null && album != _album)
                _album.Dispose();
            _albumShown = false;
            _album = album;
            _comparer.CurrentAlbum = _album;

            listViewMain.Columns.Add("Caption", 100, HorizontalAlignment.Left);
            listViewMain.Columns.Add("Taken", 70, HorizontalAlignment.Center);
            listViewMain.Columns.Add("Photographer", 100, HorizontalAlignment.Left);
            listViewMain.Columns.Add("File Name", 200, HorizontalAlignment.Left);

            if (album == null || album.Count == 0) return;

            for (int i = 0; i < album.Count; i++)
            {
                var photo = album[i];
                var item = new ListViewItem
                {
                    Text = photo.Caption,
                    Tag = i,
                    ImageIndex = PhotoIndex
                };

                item.SubItems.Add(photo.DateTaken.ToShortDateString());
                item.SubItems.Add(photo.Photographer);
                item.SubItems.Add(photo.FileName);
                listViewMain.Items.Add(item);
            }
        }

        private void editToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            if(treeViewMain.Focused)
            {
                editNametoolStripMenuItem.Enabled = (treeViewMain.SelectedNode != null);
                editNametoolStripMenuItem.Text = "&Node";
            }
            else
            {
                editNametoolStripMenuItem.Enabled = listViewMain.SelectedItems.Count > 0;
                editNametoolStripMenuItem.Text = _albumShown ? "&Name" : "&Caption";
            }
        }

        private void albumsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(treeViewMain.Nodes.Count>0)
            {
                treeViewMain.SelectedNode = treeViewMain.Nodes[0];
            }
        }

        private void photosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewMain_ItemActivate(sender, e);
        }

        private void treeViewMain_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            var node = e.Node;
            var s = node.Tag as string;
            if(s== null || (Path.GetExtension(s)!=".abm"))
            {
                return;
            }

            node.Nodes.Clear();
            using (PhotoAlbum album = OpenTreeAlbum(node))
            {
                if(album == null || album.Count == 0)
                {
                    e.Cancel = true;
                    return;
                }

                treeViewMain.BeginUpdate();
                foreach (Photograph p in album)
                {
                    var newNode = new TreeNode(album.GetDisplayText(p), PhotoIndex, SelectedPhotoIndex)
                                      {Tag = p.FileName};
                    node.Nodes.Add(newNode);
                }
                treeViewMain.EndUpdate();
            }
        }

        private PhotoAlbum OpenTreeAlbum(TreeNode node)
        {
            var s = node.Tag as string;
            var album = OpenAlbum(s);
            if(album==null)
            {
                node.ImageIndex = ErrorIndex;
                node.SelectedImageIndex = ErrorIndex;
            }
            else
            {
                node.ImageIndex = AlbumIndex;
                node.SelectedImageIndex = SelectedAlbumIndex;
            }
            return album;
        }

        private void treeViewMain_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var node = e.Node;
            var fileName = node.Tag as string;

            if(fileName==null)
                throw new ApplicationException("selected tree node has invalid tag");

            if(node.Parent == null)
            {
                LoadAlbumData(fileName);
                DisplayPhoto(null);
            }
            else if(Path.GetExtension(fileName)==".abm")
            {
                var album = OpenTreeAlbum(node);
                LoadPhotoData(album);
                DisplayPhoto(null);
            }
            else
            {
                listViewMain.Clear();
                DisplayPhoto(node);
            }
        }

        private TreeNode FindNode(string fileName, bool expandNode)
        {
            var node = treeViewMain.SelectedNode;
            if (node == null)
                return null;

            if(expandNode)
                node.Expand();

            foreach (TreeNode n in node.Nodes)
            {
                var nodePath = n.Tag as string;
                if(nodePath == fileName)
                {
                    return n;
                }
            }

            return null;
        }

        private void DisplayPhoto(TreeNode node)
        {
            if(node == null)
            {
                pictureBoxMain.Visible = false;
                listViewMain.Visible = true;
                return;
            }

            var file = node.Parent.Tag as string;
            if(_album == null 
                ||(_album.FileName != file))
            {
                if(_album != null)
                    _album.Dispose();

                _album = OpenTreeAlbum(node.Parent);
            }

            if(_album != null)
            {
                pictureBoxMain.Tag = _album[node.Index];
                pictureBoxMain.Invalidate();
                pictureBoxMain.Visible = true;
                listViewMain.Visible = false;
            }
        }

        private void pictureBoxMain_Paint(object sender, PaintEventArgs e)
        {
            var photo = pictureBoxMain.Tag as Photograph;
            if(photo == null)
            {
                e.Graphics.Clear(pictureBoxMain.BackColor);
                return;
            }

            var rect = photo.ScaleToFit(pictureBoxMain.ClientRectangle);
            e.Graphics.DrawImage(photo.Image, rect);
            e.Graphics.DrawRectangle(borderPen, rect);
        }

        private void pictureBoxMain_Resize(object sender, EventArgs e)
        {
            pictureBoxMain.Invalidate();
        }

        private void treeViewMain_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F2)
            {
                if(treeViewMain.SelectedNode != null)
                {
                    treeViewMain.SelectedNode.BeginEdit();
                    e.Handled = true;
                }
            }
        }

        private void treeViewMain_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if(e.Label == null)
            {
                e.CancelEdit = true;
                return;
            }

            if(e.Node.Parent == null)
                return;

            var fileName = e.Node.Tag as string;
            if (Path.GetExtension(fileName) == ".abm")
                e.CancelEdit = !UpdateAlbumName(e.Label, e.Node);
            else
                e.CancelEdit = !UpdatePhotoCaption(e.Label, e.Node);
        }

    }

    internal class MyListViewComparer:IComparer
    {
        private ListView _listView;
        private int _sortColumn;
        private PhotoAlbum _currentAlbum;

        public ListView ListView
        {
            get { return _listView; }
        }

        public MyListViewComparer(ListView lv)
        {
            _listView = lv;
        }

        public int SortColumn { get { return _sortColumn; } set { _sortColumn = value; } } 

        public int Compare(object x, object y)
        {
            var item1 = (ListViewItem) x;
            var item2 = (ListViewItem) y;

            if(ListView.Sorting == SortOrder.Descending)
            {
                var tmp = item1;
                item1 = item2;
                item2 = tmp;
            }

            if (ListView.View != View.Details)
                return CaseInsensitiveComparer.Default.Compare(item1.Text, item2.Text);

            return CurrentAlbum == null ? CompareAlbums(item1, item2) : ComparePhotos(item1, item2);
        }

        public PhotoAlbum CurrentAlbum   
        {
            get { return _currentAlbum; }
            set { _currentAlbum = value; }
        }

        private int ComparePhotos(ListViewItem item1, ListViewItem item2)
        {
            var sub1 = item1.SubItems[SortColumn];
            var sub2 = item2.SubItems[SortColumn];

            switch ((PhotoColumn)SortColumn)
            {
                case PhotoColumn.Caption:
                case PhotoColumn.Photographer:
                case PhotoColumn.FileName:
                    return CaseInsensitiveComparer.Default.Compare(sub1.Text, sub2.Text);
                
                case PhotoColumn.Taken:
                    var index1 = (int) item1.Tag;
                    var index2 = (int) item2.Tag;
                    var date1 = CurrentAlbum[index1].DateTaken;
                    var date2 = CurrentAlbum[index2].DateTaken;
                    return DateTime.Compare(date1, date2);

                default:
                    throw new IndexOutOfRangeException("unrecognized column index");
            }
        }

        private int CompareAlbums(ListViewItem item1, ListViewItem item2)
        {
            var sub1 = item1.SubItems[SortColumn];
            var sub2 = item2.SubItems[SortColumn];

            switch ((AlbumColumn)SortColumn)
            {
                case AlbumColumn.Name:
                case AlbumColumn.Title:
                case AlbumColumn.Password:
                    return CaseInsensitiveComparer.Default.Compare(sub1.Text, sub2.Text);

                case AlbumColumn.Size:
                    var x1 = Convert.ToInt32(sub1.Text);
                    var x2 = Convert.ToInt32(sub2.Text);
                    if (x1 < x2)
                        return -1;
                    if (x1 == x2)
                        return 0;
                    return 1;

                default:
                    throw new IndexOutOfRangeException("unrecognized column index");
            }
        }
    }
}
