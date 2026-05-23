using System.Collections.Generic;
using System.Linq;

namespace Proyecto2026
{
    // Filtro que excluye del resultado los ítems que el usuario ya consumió.
    public class ExcludeConsumedFilter : IRecommendationFilter
    {
        public List<IContent> Apply(User user, List<IContent> items)
        {
            var consumed = user.History
                .Where(i => i.Type == InteractionType.Played)
                .Select(i => i.Item)
                .ToHashSet();

            return items.Where(i => !consumed.Contains(i)).ToList();
        }
    }
}
