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

        [StringLength(50, MinimumLength = 10, ErrorMessage = "El tipo de libro debe tener entre 10 y 50 caracteres.")]
        public string TipoLibro{get;set;}
        public string Autor{get;set;}
        [Range(1,5, ErrorMessage = "Calificación media tiene que estar entre 1 y 5")]
        public int CalificacionMedia{get;set;}

         [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaLanzamiento{get;set;}

        public IList<CompraItem> CompraItems { get; set; }
        
    }
}