using System.Collections.Generic;
using System.Linq;

namespace Proyecto2026
{
    // Filtro que excluye ítems que sus tags coinciden con los tags excluidos del usuario
    public class ExcludeTagsFilter : IRecommendationFilter
    {
        public List<IContent> Apply(User user, List<IContent> items)
        {
            return items.Where(i => user.Preferences.Allows(i)).ToList();
        }
    }
}