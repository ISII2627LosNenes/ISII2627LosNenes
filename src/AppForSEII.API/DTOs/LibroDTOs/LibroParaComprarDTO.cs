using System;
using System.ComponentModel.DataAnnotations;

namespace AppForSEII.API.DTOs.LibroDTOs
{
    public class LibroParaComprarDTO
    {
        public LibroParaComprarDTO(int id, string titulo, string autor, string genero, string editorial, decimal precioCompra, int stock)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            Genero = genero;
            Editorial = editorial;
            PrecioCompra = precioCompra;
            Stock = stock;
        }

        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Autor { get; set; }

        public string Genero { get; set; }

        public string Editorial { get; set; }

        [DataType(System.ComponentModel.DataAnnotations.DataType.Currency)]
        public decimal PrecioCompra { get; set; }

        public int Stock { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is LibroParaComprarDTO dTO &&
                Id == dTO.Id &&
                Titulo == dTO.Titulo &&
                Autor == dTO.Autor &&
                Genero == dTO.Genero &&
                Editorial == dTO.Editorial &&
                PrecioCompra == dTO.PrecioCompra &&
                Stock == dTO.Stock;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Titulo, Autor, Genero, Editorial, PrecioCompra, Stock);
        }
    }
}