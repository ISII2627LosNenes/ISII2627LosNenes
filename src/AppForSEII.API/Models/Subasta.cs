namespace AppForSEII.API.Models
{
    public class Subasta
    {
        public Subasta(int id, DateTime fechasubasta, decimal precio)
        {
            Id = id;
            FechaSubasta = fechasubasta;
            PrecioSubasta = precio;

        }

        public int Id{get;set;}

        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaSubasta{get;set;}


        [DataType(System.ComponentModel.DataAnnotations.DataType.Currency)]
        [Precision(5, 2)]
        public decimal PrecioSubasta{get;set;}

    }

}