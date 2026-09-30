namespace AppForSEII.API.Models
{
    public class Compra
    {
        public Compra()
        {
            CompraItems = new List<CompraItem>();
        }

        public Compra(int id, DateTime fechaCompra, IList <CompraItem> compraItems, string codigoDescuento=null):
         this(fechaCompra, compraItems, codigoDescuento)
        {
            Id = id;
        }


        public Compra(DateTime fechaCompra, IList <CompraItem> compraItems, string codigoDescuento=null)
        {
            PrecioTotal = decimal.Round(compraItems.Sum(ci => ci.Libro.PrecioCompra * ci.Cantidad), 2);
            FechaCompra = fechaCompra;
            CompraItems = compraItems;
            CodigoDescuento = codigoDescuento;

        }

        public int Id{get;set;}

        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaCompra{get;set;}

        [Precision(10, 2)]
        public double PrecioTotal{get;set;}

        [StringLength(10, MinimumLength = 5, ErrorMessage = "El código de descuento debe tener entre 5 y 10 caracteres.")]
         public string CodigoDescuento { get; set; }

        public IList<CompraItem> CompraItems { get; set; } = new List<CompraItem>();

    }
}