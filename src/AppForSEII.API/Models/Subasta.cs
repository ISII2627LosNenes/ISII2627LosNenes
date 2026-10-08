namespace AppForSEII.API.Models
{
    public class Subasta
    {
       
        public Subasta()
        {
            SubastaItems = new List<SubastaItem>();
        }

        public Subasta(int id, DateTime fechasubasta, decimal precio, IList<SubastaItem> subastaItems, MetodoPago metodopago, ApplicationUser cliente)
        {
            Id = id;
            FechaSubasta = fechasubasta;
            PrecioSubasta = precio;
            SubastaItems = subastaItems;
            MetodoPago = metodopago;
            Cliente = cliente;
            MetodoPagoID = metodopago.Id;


        }
        [Key]
        public int Id{get;set;}

        [Required(ErrorMessage = "La fecha de la subasta es obligatoria")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaSubasta{get;set;}

        [Required(ErrorMessage = "El precio de la subasta es obligatorio")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Currency)]
        [Precision(5, 2)]
        public decimal PrecioSubasta{get;set;}

        public IList<SubastaItem> SubastaItems { get; set; } 

        [Required(ErrorMessage = "El método de pago es obligatorio")]
        public MetodoPago MetodoPago { get; set; }

        public int MetodoPagoID { get; set; }

        [Required(ErrorMessage = "El cliente es obligatorio")]
        public ApplicationUser Cliente { get; set; }


    }

}