using System;
using System.Collections.Generic;

namespace Proyecto2026
{
    // Contrato que debe cumplir cualquier tipo de contenido dentro de su plataforma.
    public interface IContent
    {
        string Title { get; set; } // Debe tener título.
        List<string> Tags { get; set; } // Lista de etiquetas (sirven para las recomendaciones y preferencias).
        int Popularity { get; set; } // Puntaje o popularidad del contenido en la plataforma.
        DateTime Date { get; set; } // Fecha de lanzamiento o de publicación del contenido.
    }
}