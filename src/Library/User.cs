using System.Collections.Generic;

namespace Proyecto2026
{
    public class User : GenericUser
    {
        public UserPreferences Preferences { get; private set; }
        public List<Interaction> History { get; private set; }

        // Constructor para crear un usuario nuevo
        public User(string username, string email, string hashedPassword)
            : base(username, email, hashedPassword)
        {
            // Como es nuevo, las preferencias y le historial empiezan vacías
            Preferences = new UserPreferences();
            History = new List<Interaction>();
        }

        // Constructor para usuarios que ya existen
        public User(string username, string email, string hashedPassword,
                    UserPreferences preferences, List<Interaction> history)
            : base(username, email, hashedPassword)
        {
            Preferences = preferences;
            History = history;
        }

        public void Consume(IContent item)
        {
            //////////// NO SE, DESPUES LO HAGO 
        }
    }
}
