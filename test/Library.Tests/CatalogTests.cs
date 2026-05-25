using System;
using NUnit.Framework;
using Proyecto2026;

namespace Library.Tests
{
    [TestFixture]
    public class CatalogTests
    {
        [Test]
        public void AddItem_AgregaItemAlCatalogo()
        {
            var catalog = new Catalog();
            var music = new Music("Song", "Artist", "Album", "Rock", DateTime.Now);
            catalog.AddItem(music);
            Assert.AreEqual(1, catalog.GetAvailableItems().Count);
        }

        [Test]
        public void RemoveItem_EliminaItemDelCatalogo()
        {
            var catalog = new Catalog();
            var music = new Music("Song", "Artist", "Album", "Rock", DateTime.Now);
            catalog.AddItem(music);
            catalog.RemoveItem(music);
            Assert.AreEqual(0, catalog.GetAvailableItems().Count);
        }

        [Test]
        public void GetAvailableItems_NoRetornaItemsEliminados()
        {
            var catalog = new Catalog();
            var music = new Music("Song", "Artist", "Album", "Rock", DateTime.Now);
            catalog.AddItem(music);
            music.MarkAsDeleted();
            Assert.AreEqual(0, catalog.GetAvailableItems().Count);
        }

        [Test]
        public void GetAvailableItems_RetornaItemsNoEliminados()
        {
            var catalog = new Catalog();
            var music1 = new Music("Song1", "Artist", "Album", "Rock", DateTime.Now);
            var music2 = new Music("Song2", "Artist", "Album", "Pop", DateTime.Now);
            catalog.AddItem(music1);
            catalog.AddItem(music2);
            music1.MarkAsDeleted();
            Assert.AreEqual(1, catalog.GetAvailableItems().Count);
        }
    }
}