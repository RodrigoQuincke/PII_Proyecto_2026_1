using System.Collections.Generic;
using System.Linq;

namespace Proyecto2026
{

    // Almacena y gestiona el catálogo de ítems disponibles para recomendar.
    // Expert: Catalog es el experto en saber qué ítems existen, cuáles están disponibles y cuáles fueron eliminados.
    // SRP: Su única responsabilidad es mantener la colección de ítems.
    public class Catalog
    {
        private List<IRecommendableItem> items;

        public Catalog()
        {
            items = new List<IRecommendableItem>();
        }


        // Agrega un ítem al catálogo.
        public void AddItem(IRecommendableItem item)
        {
            items.Add(item);
        }


        // Marca un ítem como eliminado.
        // No lo borra para preservar el historial.
        public void RemoveItem(IRecommendableItem item)
        {
            // Buscamos el ítem concreto que sea Music para llamar MarkAsDeleted
            var music = item as Music;
            if (music != null)
            {
                music.MarkAsDeleted();
            }
        }

        // Devuelve solo los ítems que NO están eliminados.
        public List<IRecommendableItem> GetAvailableItems()
        {
            return items.Where(i => !i.IsDeleted).ToList();
        }
    }
}