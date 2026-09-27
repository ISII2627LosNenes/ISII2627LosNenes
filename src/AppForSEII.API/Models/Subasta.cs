namespace AppForSEII.API.Models
{
    public class Subasta
    {
        public Subasta(int id, DateTime fechasubasta, string titulo, string? descripcion, decimal precio)
        {
            Id = id;
            Fechasubasta = fechasubasta;
            Titulo = titulo;
            Descripcion = descripcion;
            Precio = precio;

        }

        public int Id{get;set;}

        [StringLength(20, MinimumLength = 10, ErrorMessage = "El título debe tener entre 10 y 20 caracteres.")]
        public string Titulo{get;set;}

        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Fechasubasta{get;set;}

        [StringLength(100, MinimumLength = 20, ErrorMessage = "La descripción debe tener entre 20 y 100 caracteres.")]
        public string? Descripcion{get;set;}

        [DataType(System.ComponentModel.DataAnnotations.DataType.Currency)]
        [Precision(5, 2)]
        public decimal Precio{get;set;}

    }

}