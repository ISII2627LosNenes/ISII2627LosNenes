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
        public int Cantidad { get; set; }
    
     }

}