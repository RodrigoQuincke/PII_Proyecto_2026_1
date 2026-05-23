using System.Collections.Generic;
using System.Linq;

namespace Proyecto2026
{

    // Estrategia que recomienda ítems con tags similares a los del historial del usuario.
    // Si el usuario no tiene historial, retorna la lista completa sin filtrar.

    public class BasedOnHistory : IRecommendationStrategy
    {
        public List<IContent> Recommend(User user, List<IContent> items)
        {
            if (user.History.Count == 0)
                return items;

            // Recolectar todos los tags de ítems consumidos.
            var consumedTags = user.History
                .Where(i => i.Type == InteractionType.Played)
                .SelectMany(i => i.Item.Tags)
                .ToHashSet();

            // Recomendar ítems que compartan al menos un tag con el historial.
            return items
                .Where(i => i.Tags.Any(t => consumedTags.Contains(t)))
                .ToList();
        }
    }
}
