using System.Collections.Generic;
using System.Linq;

namespace Proyecto2026
{
    public class PopularitySorter : IRecommendationSorter
    {
        public List<IContent> Sort(List<IContent> items)
        {
            return items.OrderByDescending(i => i.Popularity).ToList();
        }
    }
}