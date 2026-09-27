namespace AppForSEII.API.Models
{
    public class Compra
    {
    public Compra(int id, DateTime fechaCompra, double precioTotal,string codigoDescuento=null)
    {
        Id = id;
        FechaCompra = fechaCompra;
        PrecioTotal = precioTotal;
        CodigoDescuento = codigoDescuento;
    }

    public int Id{get;set;}

    
    public DateTime FechaCompra{get;set;}

    public double PrecioTotal{get;set;}

    
    public string CodigoDescuento { get; set; }

    }
}