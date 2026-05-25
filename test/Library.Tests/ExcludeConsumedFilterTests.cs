using System;
using System.Collections.Generic;
using NUnit.Framework;
using Proyecto2026;

namespace Library.Tests
{
    [TestFixture]
    public class ExcludeConsumedFilterTests
    {
        [Test]
        public void Apply_ExcluyeItemsConsumidos()
        {
            var user = new User("juan", "juan@mail.com", "hash123");
            var music = new Music("Song", "Artist", "Album", "Rock", DateTime.Now);
            user.Consume(music);
            var filter = new ExcludeConsumedFilter();
            var result = filter.Apply(user, new List<IContent> { music });
            Assert.AreEqual(0, result.Count);
        }

        [Test]
        public void Apply_NoExcluyeItemsNoConsumidos()
        {
            var user = new User("juan", "juan@mail.com", "hash123");
            var music = new Music("Song", "Artist", "Album", "Rock", DateTime.Now);
            var filter = new ExcludeConsumedFilter();
            var result = filter.Apply(user, new List<IContent> { music });
            Assert.AreEqual(1, result.Count);
        }
    }
}