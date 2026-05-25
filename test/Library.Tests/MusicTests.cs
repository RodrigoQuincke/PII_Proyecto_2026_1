using System;
using NUnit.Framework;
using Proyecto2026;

namespace Library.Tests
{
    [TestFixture]
    public class MusicTests
    {
        [Test]
        public void Constructor_CreaMusic_ConDatosCorrectos()
        {
            var music = new Music("Song", "Artist", "Album", "Rock", DateTime.Now, 100);
            Assert.AreEqual("Song", music.Title);
            Assert.AreEqual("Artist", music.Artist);
            Assert.AreEqual("Rock", music.Genre);
            Assert.AreEqual(100, music.Popularity);
        }

        [Test]
        public void Constructor_TagsIncluyeGenero()
        {
            var music = new Music("Song", "Artist", "Album", "Rock", DateTime.Now);
            Assert.IsTrue(music.Tags.Contains("Rock"));
        }

        [Test]
        public void MarkAsDeleted_IsDeletedRetornaTrue()
        {
            var music = new Music("Song", "Artist", "Album", "Rock", DateTime.Now);
            music.MarkAsDeleted();
            Assert.IsTrue(music.IsDeleted);
        }

        [Test]
        public void IsDeleted_PorDefecto_RetornaFalse()
        {
            var music = new Music("Song", "Artist", "Album", "Rock", DateTime.Now);
            Assert.IsFalse(music.IsDeleted);
        }
    }
}