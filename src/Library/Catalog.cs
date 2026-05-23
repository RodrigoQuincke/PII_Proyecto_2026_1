using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Proyecto2026
{

    // Almacena y gestiona el catálogo de ítems disponibles para recomendar.
    // Expert: Catalog es el experto en saber qué ítems existen, cuáles están disponibles y cuáles fueron eliminados.
    // SRP: Su única responsabilidad es gestionar el catálogo.
    public class Catalog
    {
        private List<IContent> items;

        public Catalog()
        {
            items = new List<IContent>();
        }


        // Agrega un ítem al catálogo.
        public void AddItem(IContent item)
        {
            items.Add(item);
        }


        // Elimina un ítem del catálogo.
        public void RemoveItem(IContent item)
        {
            items.Remove(item);
        }

        // Retorna solo los ítems disponibles (no eliminados).
        public List<IContent> GetAvailableItems()
        {
            return items;
        }
    }
}
