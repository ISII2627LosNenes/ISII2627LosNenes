namespace AppForSEII.API.Models
{
    [PrimaryKey(nameof(SubastaId))]
    public class SubastaItem
    {
        public SubastaItem(Subasta subasta,  string? descripcion, decimal precioPuja, List<Libro> libros)
        {
            SubastaId = subasta.Id;
            Descripcion = descripcion;
            PrecioPuja = precioPuja;
            Subasta = subasta;
        }

        public int SubastaId { get; set; }
        public string Nombre { get; set; }
        public Subasta Subasta { get; set; }

        [StringLength(100, MinimumLength = 20, ErrorMessage = "La descripción debe tener entre 20 y 100 caracteres.")]
        public string? Descripcion { get; set; }

        [Precision(10, 2)]
        public decimal PrecioPuja { get; set; }

        public List<Libro> Libros { get; set; } 

    }
}