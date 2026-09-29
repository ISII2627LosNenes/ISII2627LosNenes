namespace AppForSEII.API.Models
{
    [PrimaryKey(nameof(SubastaId),nameof(LibroId))]
    public class SubastaItem
    {
        public SubastaItem()
        {
            
        }
        public SubastaItem(Subasta subasta,  string? descripcion, decimal precioPuja, Libro libro)
        {
            SubastaId = subasta.Id;
            Descripcion = descripcion;
            PrecioPuja = precioPuja;
            LibroId = libro.Id;
            Libro = libro;
            Subasta = subasta;
        }
     

        public int SubastaId { get; set; }
        public int LibroId { get; set; }
        public Libro Libro { get; set; }
        public Subasta Subasta { get; set; }

        [StringLength(100, MinimumLength = 20, ErrorMessage = "La descripción debe tener entre 20 y 100 caracteres.")]
        public string? Descripcion { get; set; }

        [DataType(System.ComponentModel.DataAnnotations.DataType.Currency)]
        [Precision(10, 2)]
        public decimal PrecioPuja { get; set; }


    }
}