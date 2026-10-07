namespace AppForSEII.API.Models
{
    public class Compra
    {
        public Compra()
        {
            CompraItems = new List<CompraItem>();
        }

        public Compra(int id, DateTime fechaCompra, IList <CompraItem> compraItems, string codigoDescuento, ApplicationUser cliente, MetodoPago metodoPago) :
         this(fechaCompra, compraItems, codigoDescuento, cliente, metodoPago)
        {
            Id = id;
        }


        public Compra(DateTime fechaCompra, IList <CompraItem> compraItems, string codigoDescuento, ApplicationUser cliente, MetodoPago metodoPago)
        {
            PrecioTotal = decimal.Round(compraItems.Sum(ci => ci.Libro.PrecioCompra * ci.Cantidad), 2);
            FechaCompra = fechaCompra;
            CompraItems = compraItems;
            CodigoDescuento = codigoDescuento;
            Cliente = cliente;

            MetodoPago = metodoPago;
            MetodoPagoId = metodoPago.Id;

        }

        public int Id{get;set;}

        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaCompra{get;set;}

        [Precision(10, 2)]
        public decimal PrecioTotal{get;set;}

        [StringLength(10, MinimumLength = 5, ErrorMessage = "El código de descuento debe tener entre 5 y 10 caracteres.")]
         public string? CodigoDescuento { get; set; }

        public IList<CompraItem> CompraItems { get; set; } = new List<CompraItem>();

        [Required(ErrorMessage = "El cliente es obligatorio.")]
        public  ApplicationUser Cliente { get; set; } 

    

    }
}