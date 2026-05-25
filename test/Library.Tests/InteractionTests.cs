using System;
using NUnit.Framework;
using Proyecto2026;

namespace Library.Tests
{
    [TestFixture]
    public class InteractionTests
    {
        [Test]
        public void IsRecent_InteraccionReciente_RetornaTrue()
        {
            var music = new Music("Song", "Artist", "Album", "Rock", DateTime.Now);
            var interaction = new Interaction(music, InteractionType.Played, DateTime.Now);
            Assert.IsTrue(interaction.IsRecent(1));
        }

        [Test]
        public void IsRecent_InteraccionAntigua_RetornaFalse()
        {
            var music = new Music("Song", "Artist", "Album", "Rock", DateTime.Now);
            var interaction = new Interaction(music, InteractionType.Played, DateTime.Now.AddDays(-10));
            Assert.IsFalse(interaction.IsRecent(5));
        }
    }
}