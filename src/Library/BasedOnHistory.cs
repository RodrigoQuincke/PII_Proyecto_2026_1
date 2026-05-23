using System.Collections.Generic;
using System.Linq;

namespace Proyecto2026
{

    // Filtro que excluye del resultado los ítems que el usuario ya consumió.
    // Expert: Esta clase es la experta para decidir que ítems excluir porque es quien  conoce que ítems ya consumio el usuario.
    // SRP: Su única responsabilidad es filtrar por historial de consumo.
    // Implementa IRecommendationFilter para poder combinarse con otros filtros.

    public class BasedOnHistory : IRecommendationFilter
    {
        //  Devuelve los ítems que no aparecen en el historial del usuario.
        public List<IRecommendableItem> Apply(User user, List<IRecommendableItem> items)
        {
            // FALTA ARMAR
        }
    }
}
