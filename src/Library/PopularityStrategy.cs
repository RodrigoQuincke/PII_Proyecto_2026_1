using System.Collections.Generic;
using System.Linq;

namespace Proyecto2026
{

    // Estrategia de popularidad: recomienda los ítems más populares del catálogo.
    // Se usa como estrategia para usuarios nuevos sin historial ni preferencias.
    public class PopularityStrategy : IRecommendationStrategy
    {
        private readonly int topN;

        // Cantidad máxima de ítems a retornar. Por defecto 10.
        public PopularityStrategy(int topN = 10)
        {
            this.topN = topN;
        }

        public List<IContent> Recommend(User user, List<IContent> items)
        {
            return items
                .OrderByDescending(i => i.Popularity)
                .Take(topN)
                .ToList();
        }
    }
}
