namespace AppForSEII.API.Models
{
[PrimaryKey(nameof(LibroId), nameof(CompraId))]
    public class CompraItem
    {
        public CompraItem(int cantidad, int libroId, int compraId) 
        { 
            Cantidad = cantidad; 
            LibroId = libroId; 
            CompraId = compraId;
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