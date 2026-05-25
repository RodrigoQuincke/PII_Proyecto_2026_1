using System;
using System.Collections.Generic;
using NUnit.Framework;
using Proyecto2026;

namespace Library.Tests
{
    [TestFixture]
    public class RecommendationFacadeTests
    {
        private RecommendationFacade BuildFacade()
        {
            var catalog = new Catalog();
            var strategy = new PopularityStrategy();
            var filters = new List<IRecommendationFilter> { new ExcludeConsumedFilter() };
            var sorter = new PopularitySorter();
            var engine = new RecommendationEngine(strategy, filters, sorter);
            return new RecommendationFacade(catalog, engine);
        }

        [Test]
        public void RegisterUser_CreaUsuarioCorrectamente()
        {
            var facade = BuildFacade();
            var user = facade.RegisterUser("juan", "juan@mail.com", "hash123");
            Assert.AreEqual("juan", user.Username);
        }

        [Test]
        public void RegisterUser_UsuarioDuplicado_LanzaExcepcion()
        {
            var facade = BuildFacade();
            facade.RegisterUser("juan", "juan@mail.com", "hash123");
            Assert.Throws<InvalidOperationException>(() =>
                facade.RegisterUser("juan", "otro@mail.com", "hash456"));
        }

        [Test]
        public void GetRecommendations_NoRetornaItemsEliminados()
        {
            var facade = BuildFacade();
            var user = facade.RegisterUser("juan", "juan@mail.com", "hash123");
            var music = new Music("Song", "Artist", "Album", "Rock", DateTime.Now, 100);
            facade.AddMusic(music);
            music.MarkAsDeleted();
            var result = facade.GetRecommendations(user);
            Assert.AreEqual(0, result.Count);
        }

        [Test]
        public void GetRecommendations_NoRetornaItemsConsumidos()
        {
            var facade = BuildFacade();
            var user = facade.RegisterUser("juan", "juan@mail.com", "hash123");
            var music = new Music("Song", "Artist", "Album", "Rock", DateTime.Now, 100);
            facade.AddMusic(music);
            facade.RegisterInteraction(user, music, InteractionType.Played);
            var result = facade.GetRecommendations(user);
            Assert.AreEqual(0, result.Count);
        }
    }
}