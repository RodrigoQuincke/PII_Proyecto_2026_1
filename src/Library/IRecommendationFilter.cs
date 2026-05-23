using System.Collections.Generic;

namespace Proyecto2026
{
    // Contrato para filtros aplicables sobre una lista de ítems.
    public interface IRecommendationFilter
    {
        // Aplica el filtro y retorna solo los ítems que pasan la condición.
        List<IContent> Apply(User user, List<IContent> items);
    }
}
