using System;
using System.Collections.Generic;
using NUnit.Framework;
using Proyecto2026;

namespace Library.Tests
{
    [TestFixture]
    public class BasedOnPreferencesTests
    {
        [Test]
        public void Recommend_SinPreferencias_RetornaTodos()
        {
            var user = new User("juan", "juan@mail.com", "hash123");
            var music = new Music("Song", "Artist", "Album", "Rock", DateTime.Now);
            var strategy = new BasedOnPreferences();
            var result = strategy.Recommend(user, new List<IContent> { music });
            Assert.AreEqual(1, result.Count);
        }

        [Test]
        public void Recommend_ConPreferencias_RetornaSoloCoincidentes()
        {
            var prefs = new UserPreferences(new List<string> { "Rock" }, new List<string>());
            var user = new User("juan", "juan@mail.com", "hash123", prefs, new List<Interaction>());
            var rock = new Music("Rock Song", "Artist", "Album", "Rock", DateTime.Now);
            var pop = new Music("Pop Song", "Artist", "Album", "Pop", DateTime.Now);
            var strategy = new BasedOnPreferences();
            var result = strategy.Recommend(user, new List<IContent> { rock, pop });
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Rock Song", result[0].Title);
        }
    }
}