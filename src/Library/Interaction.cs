using System;

namespace Proyecto2026
{
    // Representa una acción realizada por el usuario en la app
    public class Interaction
    {
        // Datos que guarda cada interacción (contenido con el que interactuó, tipo de interacción y fecha exacta)
        public IContent Item { get; set; }
        public InteractionType Type { get; set; }
        public DateTime Date { get; set; }

        public Interaction(IContent item, InteractionType type, DateTime date)
        {
            Item = item;
            Type = type;
            Date = date;
        }

        // Averigua si esta interacción sucedió dentro de un rango reciente de días
        public bool IsRecent(int days)
        {
            return (DateTime.Now - Date).TotalDays <= days;
        }
    }
}
