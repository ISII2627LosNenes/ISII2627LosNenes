namespace AppForSEII.API.Models
{
[PrimaryKey(nameof(LibroId), nameof(CompraId))]
    public class CompraItem
    {
        public CompraItem()
        {
        }
        public CompraItem(int cantidad, Libro libro, Compra compra) 
        { 
            Cantidad = cantidad;
            Libro = libro;
            LibroId = libro.Id;
            Compra = compra;
            CompraId = compra.Id;
        } 

        [Required(ErrorMessage = "El libro es obligatorio.")]
        public Libro Libro { get; set; }
        public int LibroId { get; set; } 

        [Required(ErrorMessage = "La compra es obligatoria.")]
        public Compra Compra { get; set; } 
        public int CompraId { get; set; } 

        [Required(ErrorMessage = "La cantidad de compra es obligatoria.")]
        [Range(1, int.MaxValue, ErrorMessage = "La cantidad de compra debe ser mayor que 1")]
        public int Cantidad { get; set; }
    
     }

}