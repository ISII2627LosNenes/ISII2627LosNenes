namespace AppForSEII.API.Models
{
    public class Subasta
    {
       
        public Subasta()
        {
            SubastaItems = new List<SubastaItem>();
        }

        public Subasta(int id, DateTime fechasubasta, decimal precio, List<SubastaItem> subastaItems)
        {
            Id = id;
            FechaSubasta = fechasubasta;
            PrecioSubasta = precio;
            SubastaItems = subastaItems;


        }

        public int Id{get;set;}

        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaSubasta{get;set;}


        [DataType(System.ComponentModel.DataAnnotations.DataType.Currency)]
        [Precision(5, 2)]
        public decimal PrecioSubasta{get;set;}

        public List<SubastaItem> SubastaItems { get; set; } 

        public MetodoPago MetodoPago { get; set; }

        public  ApplicationUser Cliente { get; set; } 

    }

}