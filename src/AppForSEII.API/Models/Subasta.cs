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

        public int Id{get;set;}

        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaSubasta{get;set;}


        [DataType(System.ComponentModel.DataAnnotations.DataType.Currency)]
        [Precision(5, 2)]
        public decimal PrecioSubasta{get;set;}

        public IList<SubastaItem> SubastaItems { get; set; } 

        public MetodoPago MetodoPago { get; set; }

        public int MetodoPagoID { get; set; }



        public virtual ApplicationUser Cliente { get; set; } //Para ver que este el usuario registrado y que pueda hacer la reseña, si no esta registrado no puede hacer la reseña


    }

}