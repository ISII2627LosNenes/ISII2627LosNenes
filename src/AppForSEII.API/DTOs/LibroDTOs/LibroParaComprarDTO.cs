using System;
using System.ComponentModel.DataAnnotations;

namespace AppForSEII.API.DTOs.LibroDTOs
{
    public class LibroParaComprarDTO
    {
        public LibroParaComprarDTO(int id, string titulo, DateTime fechaLanzamiento, string genero, string editorial, decimal precioCompra)
        {
            Id = id;
            Titulo = titulo;
            FechaLanzamiento = fechaLanzamiento;
            Genero = genero;
            Editorial = editorial;
            PrecioCompra = precioCompra;
                        
        }

        public int Id { get; set; }

        public string Titulo { get; set; }

        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaLanzamiento { get; set; }

        public string Genero { get; set; }

        public string Editorial { get; set; }

        [DataType(System.ComponentModel.DataAnnotations.DataType.Currency)]
        public decimal PrecioCompra { get; set; }

        

        public override bool Equals(object? obj)
        {
            return obj is LibroParaComprarDTO dTO &&
                Id == dTO.Id &&
                Titulo == dTO.Titulo &&
                FechaLanzamiento == dTO.FechaLanzamiento &&
                Genero == dTO.Genero &&
                Editorial == dTO.Editorial &&
                PrecioCompra == dTO.PrecioCompra;
                
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Titulo, FechaLanzamiento, Genero, Editorial, PrecioCompra);
        }
    }
}