using System.Collections.Generic;
using System;

namespace Proyecto2026
{
    // Expert: User es el experto en su propio historial y preferencias.
    // SRP: User gestiona los datos del usuario.
    public class User : GenericUser
    {
        public UserPreferences Preferences { get; private set; }
        public List<Interaction> History { get; private set; }

        // Constructor para crear un usuario nuevo
        public User(string username, string email, string hashedPassword)
            : base(username, email, hashedPassword)
        {
            // Como es nuevo, las preferencias y le historial empiezan vacías.
            Preferences = new UserPreferences();
            History = new List<Interaction>();
        }

        // Constructor para usuarios que ya existen.
        public User(string username, string email, string hashedPassword,
                    UserPreferences preferences, List<Interaction> history)
            : base(username, email, hashedPassword)
        {
            Preferences = preferences;
            History = history;
        }

        // Registra que el usuario consumió un ítem.
        public void Consume(IContent item)
        {
            var interaction = new Interaction(item, InteractionType.Played, DateTime.Now);
            History.Add(interaction);
        }
    }
}
