using System;
using System.Collections.Generic;
using NUnit.Framework;
using Proyecto2026;

namespace Library.Tests
{
    [TestFixture]
    public class UserTests
    {
        [Test]
        public void Constructor_NuevoUsuario_HistorialVacio()
        {
            var user = new User("juan", "juan@mail.com", "hash123");
            Assert.AreEqual(0, user.History.Count);
        }

        [Test]
        public void Constructor_NuevoUsuario_PreferenciasVacias()
        {
            var user = new User("juan", "juan@mail.com", "hash123");
            Assert.AreEqual(0, user.Preferences.PreferredTags.Count);
            Assert.AreEqual(0, user.Preferences.ExcludedTags.Count);
        }

        [Test]
        public void Consume_AgregaInteraccionAlHistorial()
        {
            var user = new User("juan", "juan@mail.com", "hash123");
            var music = new Music("Song", "Artist", "Album", "Rock", DateTime.Now);
            user.Consume(music);
            Assert.AreEqual(1, user.History.Count);
        }

        [Test]
        public void Consume_InteraccionEsDeTypePlayed()
        {
            var user = new User("juan", "juan@mail.com", "hash123");
            var music = new Music("Song", "Artist", "Album", "Rock", DateTime.Now);
            user.Consume(music);
            Assert.AreEqual(InteractionType.Played, user.History[0].Type);
        }
    }
}