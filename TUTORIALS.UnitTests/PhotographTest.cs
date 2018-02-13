using System;
using System.Drawing;
using NUnit.Framework;
using NUnit.Mocks;
using TUTORIALS.Library;

namespace TUTORIALS.UnitTests
{
    [TestFixture]
    public class PhotographTest
    {
        private readonly string fileName = "anything";
        [Test]
        public void PhotographConstruction_ImageNotValid()
        {
            var photo = new Photograph(fileName);
            Assert.False(photo.IsImageValid);
        }

        [Test]
        public void PhotographsEquals_WhenHaveSameNames()
        {
            var photo = new Photograph(fileName);
            var photo2 = new Photograph(fileName);
            Assert.True(photo.Equals(photo2));
        }

        [Test]
        public void PhotographsToString_ReturnFileName()
        {
            var photo = new Photograph(fileName);
            Assert.AreEqual(fileName, photo.ToString());
        }

        [Test]
        public void PhotographDispose_BitmapDispose()
        {
            var photo = new Photograph(fileName);
            photo.Dispose();
            Assert.True(photo.IsDisposed());
        }
    }

}