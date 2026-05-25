using System;
using System.Collections.Generic;
using NUnit.Framework;
using Proyecto2026;

namespace Library.Tests
{
    [TestFixture]
    public class PopularityStrategyTests
    {
        [Test]
        public void Recommend_RetornaItemsOrdenadosPorPopularidad()
        {
            var user = new User("juan", "juan@mail.com", "hash123");
            var low = new Music("Low", "Artist", "Album", "Rock", DateTime.Now, 10);
            var high = new Music("High", "Artist", "Album", "Rock", DateTime.Now, 100);
            var strategy = new PopularityStrategy();
            var result = strategy.Recommend(user, new List<IContent> { low, high });
            Assert.AreEqual("High", result[0].Title);
        }

        [Test]
        public void Recommend_RespetaLimiteTopN()
        {
            var user = new User("juan", "juan@mail.com", "hash123");
            var items = new List<IContent>();
            for (int i = 0; i < 15; i++)
                items.Add(new Music($"Song{i}", "Artist", "Album", "Rock", DateTime.Now, i));
            var strategy = new PopularityStrategy(5);
            var result = strategy.Recommend(user, items);
            Assert.AreEqual(5, result.Count);
        }
    }
}