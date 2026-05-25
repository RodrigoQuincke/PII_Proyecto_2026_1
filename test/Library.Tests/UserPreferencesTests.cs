using System;
using System.Collections.Generic;
using NUnit.Framework;
using Proyecto2026;

namespace Library.Tests
{
    [TestFixture]
    public class UserPreferencesTests
    {
        [Test]
        public void Allows_ItemSinTagsExcluidos_RetornaTrue()
        {
            var prefs = new UserPreferences(new List<string>(), new List<string> { "Pop" });
            var music = new Music("Song", "Artist", "Album", "Rock", DateTime.Now);
            Assert.IsTrue(prefs.Allows(music));
        }

        [Test]
        public void Allows_ItemConTagExcluido_RetornaFalse()
        {
            var prefs = new UserPreferences(new List<string>(), new List<string> { "Rock" });
            var music = new Music("Song", "Artist", "Album", "Rock", DateTime.Now);
            Assert.IsFalse(prefs.Allows(music));
        }

        [Test]
        public void Allows_SinTagsExcluidos_SiempreRetornaTrue()
        {
            var prefs = new UserPreferences();
            var music = new Music("Song", "Artist", "Album", "Rock", DateTime.Now);
            Assert.IsTrue(prefs.Allows(music));
        }
    }
}