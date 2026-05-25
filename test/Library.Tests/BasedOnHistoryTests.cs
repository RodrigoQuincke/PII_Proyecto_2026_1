using System;
using System.Collections.Generic;
using NUnit.Framework;
using Proyecto2026;

namespace Library.Tests
{
    [TestFixture]
    public class BasedOnHistoryTests
    {
        [Test]
        public void Recommend_SinHistorial_RetornaTodos()
        {
            var user = new User("juan", "juan@mail.com", "hash123");
            var music = new Music("Song", "Artist", "Album", "Rock", DateTime.Now);
            var strategy = new BasedOnHistory();
            var result = strategy.Recommend(user, new List<IContent> { music });
            Assert.AreEqual(1, result.Count);
        }

        [Test]
        public void Recommend_ConHistorial_RetornaSoloItemsConTagsSimilares()
        {
            var user = new User("juan", "juan@mail.com", "hash123");
            var consumed = new Music("Consumed", "Artist", "Album", "Rock", DateTime.Now);
            user.Consume(consumed);
            var rock = new Music("Rock Song", "Artist", "Album", "Rock", DateTime.Now);
            var pop = new Music("Pop Song", "Artist", "Album", "Pop", DateTime.Now);
            var strategy = new BasedOnHistory();
            var result = strategy.Recommend(user, new List<IContent> { rock, pop });
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Rock Song", result[0].Title);
        }
    }
}