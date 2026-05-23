using System;
using System.Collections.Generic;

namespace Proyecto2026
{

    // Representa una canción o álbum en el catálogo.
    // Es el único dominio concreto del sistema.

    public class Music : IContent
    {
        public string Title { get; set; }
        public List<string> Tags { get; set; }
        public int Popularity { get; set; }
        public DateTime Date { get; set; }

        public string Artist { get; set; }
        public string Album { get; set; }
        public string Genre { get; set; }

        private bool deleted = false;

        public Music(string title, string artist, string album, string genre, DateTime date, int popularity = 0)
        {
            Title = title;
            Artist = artist;
            Album = album;
            Genre = genre;
            Date = date;
            Popularity = popularity;
            Tags = new List<string> { genre };
        }

        // Marca el ítem como eliminado sin borrarlo físicamente.
        // Permite que Catalog lo excluya sin romper el historial de interacciones existentes.
        public void MarkAsDeleted()
        {
            deleted = true;
        }

        // Indica si el ítem fue marcado como eliminado.
        public bool IsDeleted => deleted;
    }
}