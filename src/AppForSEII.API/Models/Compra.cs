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

    [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime FechaCompra{get;set;}

    public double PrecioTotal{get;set;}

    
    public string CodigoDescuento { get; set; }

    }
}