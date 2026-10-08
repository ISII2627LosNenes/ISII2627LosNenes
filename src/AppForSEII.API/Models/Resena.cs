namespace AppForSEII.API.Models
{
    public class Resena
    {
        public Resena()
        {
            ResenaItems = new List<ResenaItem>();
        }
        public Resena(int id, DateTime fecharesena, string titulo, IList<ResenaItem> resenaItems, ApplicationUser cliente, string nombreCliente, string apellidoCliente, string direccionCliente, string telefonoCliente)
        {
            Id = id;
            Fecharesena = fecharesena;
            Titulo = titulo;
            ResenaItems = resenaItems;
            Cliente = cliente;
            NombreCliente = nombreCliente;
            ApellidoCliente = apellidoCliente;
            DireccionCliente = direccionCliente;
            TelefonoCliente = telefonoCliente;
        }
        [Key]
        public int Id{get;set;}

        [Required(ErrorMessage = "La calificación es obligatoria")]
        [StringLength(20, MinimumLength = 10, ErrorMessage = "El título debe tener entre 10 y 20 caracteres.")]
        public string Titulo{get;set;}

        [Required(ErrorMessage = "El nombre del cliente es obligatorio")]
        public string NombreCliente{get;set;}

        [Required(ErrorMessage = "El apellido del cliente es obligatorio")]
        public string ApellidoCliente{get;set;}

        [Required(ErrorMessage = "La dirección del cliente es obligatoria")]
        public string DireccionCliente{get;set;}

        [Required(ErrorMessage = "El teléfono del cliente es obligatorio")]
        public string TelefonoCliente{get;set;}
        

        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Fecharesena{get;set;}

        public IList<ResenaItem> ResenaItems { get; set; } = new List<ResenaItem>();

        public  ApplicationUser Cliente { get; set; } 
    }
}