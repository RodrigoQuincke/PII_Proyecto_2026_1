using System;
using System.Collections.Generic;
using NUnit.Framework;
using Proyecto2026;

namespace Library.Tests
{
    [TestFixture]
    public class ExcludeTagsFilterTests
    {
        [Test]
        public void Apply_ExcluyeItemsConTagsExcluidos()
        {
            var prefs = new UserPreferences(new List<string>(), new List<string> { "Rock" });
            var user = new User("juan", "juan@mail.com", "hash123", prefs, new List<Interaction>());
            var music = new Music("Song", "Artist", "Album", "Rock", DateTime.Now);
            var filter = new ExcludeTagsFilter();
            var result = filter.Apply(user, new List<IContent> { music });
            Assert.AreEqual(0, result.Count);
        }

        [Test]
        public void Apply_NoExcluyeItemsSinTagsExcluidos()
        {
            var prefs = new UserPreferences(new List<string>(), new List<string> { "Pop" });
            var user = new User("juan", "juan@mail.com", "hash123", prefs, new List<Interaction>());
            var music = new Music("Song", "Artist", "Album", "Rock", DateTime.Now);
            var filter = new ExcludeTagsFilter();
            var result = filter.Apply(user, new List<IContent> { music });
            Assert.AreEqual(1, result.Count);
        }
    }
}