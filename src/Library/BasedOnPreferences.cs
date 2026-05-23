using System.Collections.Generic;
using System.Linq;

namespace Proyecto2026
{
    // Estrategia que recomienda ítems que coinciden con las preferencias del usuario.
    // Si el usuario no tiene preferencias definidas, retorna todos los ítems.
    public class BasedOnPreferences : IRecommendationStrategy
    {
        public List<IContent> Recommend(User user, List<IContent> items)
        {
            var preferred = user.Preferences.PreferredTags;

            if (preferred.Count == 0)
                return items;

            return items
                .Where(i => i.Tags.Any(t => preferred.Contains(t)))
                .ToList();
        }
    }
}
