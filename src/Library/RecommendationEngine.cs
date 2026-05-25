using System.Collections.Generic;
using System.Linq;

namespace Proyecto2026
{

    // Motor de recomendación: aplica la estrategia y los filtros sobre los ítems del catálogo.
    // Trabaja con abstracciones.
    public class RecommendationEngine
    {
        private IRecommendationStrategy strategy;
        private List<IRecommendationFilter> filters;
        private IRecommendationSorter sorter;

        public RecommendationEngine(IRecommendationStrategy strategy, List<IRecommendationFilter> filters, IRecommendationSorter sorter)
        {
            this.strategy = strategy;
            this.sorter = sorter;
            this.filters = filters ?? new List<IRecommendationFilter>();
        }

        // Genera recomendaciones para el usuario:
        // Pipeline: estrategia → filtros → ordenamiento → resultado final.
        public List<IContent> Recommend(User user, List<IContent> items)
        {
            // 1. Estrategia: obtiene candidatos como IRecommendableItem
            var recommended = strategy.Recommend(user, items);

            var result = recommended.OfType<IContent>().ToList();

            // 2. Filtros.
            foreach (var filter in filters)
            {
                result = filter.Apply(user, result);
            }

            // 3. Ordenamiento.
            return sorter.Sort(result);
        }
    }
}