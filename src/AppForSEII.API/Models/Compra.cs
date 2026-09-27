namespace AppForSEII.API.Models
{
    
    public Compra(int id, DateTime fechaCompra, double precioTotal,string codigoDescuento=null)
    {
        Id = id;
        FechaCompra = fechaCompra;
        PrecioTotal = precioTotal;
        CodigoDescuento = codigoDescuento;
    }




}