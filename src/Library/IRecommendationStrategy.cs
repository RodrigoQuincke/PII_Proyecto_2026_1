using System.Collections.Generic;

namespace Proyecto2026
{

    // Contrato para las distintas estrategias de recomendación.
    public interface IRecommendationStrategy
    {
        // Genera una lista de ítems recomendados para el usuario.
        List<IContent> Recommend(User user, List<IContent> items);
    }
}
