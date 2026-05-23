using System.Collections.Generic;

namespace Proyecto2026
{
    // Almacena las preferencias de un usuario.
    // SRP: solo gestiona preferencias, no las aplica al motor.
    public class UserPreferences
    {
        public List<string> PreferredTags { get; private set; }
        public List<string> ExcludedTags { get; private set; }

        // Constructor para preferencias nuevas.
        public UserPreferences()
        {
            PreferredTags = new List<string>();
            ExcludedTags = new List<string>();
        }

        // Constructor para cargar preferencias existentes.
        public UserPreferences(List<string> preferredTags, List<string> excludedTags)
        {
            PreferredTags = preferredTags;
            ExcludedTags = excludedTags;
        }

        // Retorna true si el ítem pasa el filtro de exclusión.
        public bool Allows(IContent item)
        {
            // Verificar que el item no tenga tags excluidos.
            foreach (var tag in item.Tags)
            {
                if (ExcludedTags.Contains(tag))
                    return false; // Se rechaza inmediatamente
            }
            return true; // Si pasa el filtro, se permite
        }
    }
}
