namespace AppForSEII.API.Models
{
    public class Libro
    {
        public Libro(int id, string titulo, string tipoLibro, string autor, int calificacionMedia, DateTime fechaLanzamiento)
        {
            Id = id;
            Titulo = titulo;
            TipoLibro = tipoLibro;
            Autor = autor;
             CalificacionMedia = calificacionMedia;
            FechaLanzamiento = fechaLanzamiento;
        }

        public int Id{get;set;}
        public string Titulo{get;set;}
        public string TipoLibro{get;set;}
        public string Autor{get;set;}
        public int CalificacionMedia{get;set;}
        public DateTime FechaLanzamiento{get;set;}
        
    }
}