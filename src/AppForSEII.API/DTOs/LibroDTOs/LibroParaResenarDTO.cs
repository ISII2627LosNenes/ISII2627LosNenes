using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForSEII.API.DTOs.LibroDTOs 
{
    public class LibroParaResenarDTO
    {
        public LibroParaResenarDTO(int id, string titulo, string tipoLibro, string genero, string editorial, string autor, int calificacionMedia, DateTime fechaLanzamiento, decimal precioCompra)
        {
            Id = id;
            Titulo = titulo;
            TipoLibro = tipoLibro;
            Genero = genero;
            Editorial = editorial;
            Autor = autor;
            CalificacionMedia = calificacionMedia;
            FechaLanzamiento = fechaLanzamiento;
            PrecioCompra = precioCompra;
        }

        public int Id { get; set; }

        public string Titulo { get; set; }

        [StringLength(50, MinimumLength = 10, ErrorMessage = "El tipo de libro debe tener entre 10 y 50 caracteres.")]
        public string TipoLibro { get; set; }

        public string Genero { get; set; }

        public string Editorial { get; set; }

        public string Autor { get; set; }

        [Range(1, 5, ErrorMessage = "Calificación media tiene que estar entre 1 y 5")]
        public int CalificacionMedia { get; set; }

        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaLanzamiento { get; set; }

        [DataType(System.ComponentModel.DataAnnotations.DataType.Currency)]
        public decimal PrecioCompra { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is LibroParaResenarDTO dTO &&
                   Id == dTO.Id &&
                   Titulo == dTO.Titulo &&
                   TipoLibro == dTO.TipoLibro &&
                   Genero == dTO.Genero &&
                   Editorial == dTO.Editorial &&
                   Autor == dTO.Autor &&
                   CalificacionMedia == dTO.CalificacionMedia &&
                   FechaLanzamiento == dTO.FechaLanzamiento &&
                   PrecioCompra == dTO.PrecioCompra;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Titulo, TipoLibro, Genero, Editorial, Autor, CalificacionMedia, FechaLanzamiento);
            //Preguntar por que no me deja deevolver 9 elementos y 7 si
        }
    }
}