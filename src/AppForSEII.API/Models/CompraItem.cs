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

        public Libro Libro { get; set; }
        public int LibroId { get; set; } 
        public Compra Compra { get; set; } 
        public int CompraId { get; set; } 

        [Required]
        [Range(2, int.MaxValue, ErrorMessage = "La cantidad de compra debe ser mayor que 1.")]
        public int Cantidad { get; set; }
    
     }

}