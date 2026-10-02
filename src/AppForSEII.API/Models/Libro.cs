namespace AppForSEII.API.Models
{
    public class Libro
    {
        public Libro()
        {
            CompraItems = new List<CompraItem>();
            ResenaItems = new List<ResenaItem>();
            ReposicionItems = new List<ReposicionItem>();
            SubastaItems = new List<SubastaItem>();
        }
        public Libro(int id, Genero genero, int generoId, Editorial editorial, int editorialId, string titulo, string tipoLibro, string autor, int calificacionMedia, DateTime fechaLanzamiento, decimal precioCompra, decimal precioReposicion, int stock, IList<CompraItem> compraItems, IList<ResenaItem> resenaItems, IList<SubastaItem> subastaItems, IList<ReposicionItem> reposicionItems)
        {
            Id = id;
            Titulo = titulo;
            GeneroId = generoId;
            Genero = genero;
            EditorialId = editorialId;
            Editorial = editorial;
            TipoLibro = tipoLibro;
            Autor = autor;
            CalificacionMedia = calificacionMedia;
            FechaLanzamiento = fechaLanzamiento;
            PrecioCompra = precioCompra;
            PrecioReposicion=precioReposicion;
            Stock = stock;
            CompraItems = compraItems;
            ResenaItems = resenaItems;
            SubastaItems = subastaItems;
            ReposicionItems = reposicionItems;
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

        [Precision(10, 2)]
        public decimal PrecioCompra { get; set; }

        [Precision(10, 2)]
        public decimal PrecioReposicion { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "El stock no puede ser negativo")]
        public int Stock { get; set; }

        public Genero Genero { get; set; }
        public int GeneroId { get; set; }

        public Editorial Editorial { get; set; }
        public int EditorialId { get; set; }

        public IList<CompraItem> CompraItems { get; set; }

        public IList<ResenaItem> ResenaItems { get; set; }
        
        public IList<ReposicionItem> ReposicionItems { get; set; }

        public IList<SubastaItem> SubastaItems { get; set; }    
    }
}