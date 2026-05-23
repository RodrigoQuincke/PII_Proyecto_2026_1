using System.Collections.Generic;

namespace Proyecto2026
{
    // Contrato para ordenar una lista de ítems recomendados.
    public interface IRecommendationSorter
    {
        // Ordena y retorna la lista según el criterio implementado.
        List<IContent> Sort(List<IContent> items);
    }
}