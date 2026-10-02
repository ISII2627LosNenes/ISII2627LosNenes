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
        public int Id{get;set;}

        [StringLength(20, MinimumLength = 10, ErrorMessage = "El título debe tener entre 10 y 20 caracteres.")]
        public string Titulo{get;set;}

        public string NombreCliente{get;set;}

        public string ApellidoCliente{get;set;}

        public string DireccionCliente{get;set;}

        public string TelefonoCliente{get;set;}
        

        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Fecharesena{get;set;}

        public IList<ResenaItem> ResenaItems { get; set; }

        public  ApplicationUser Cliente { get; set; } //Para ver que este el usuario registrado y que pueda hacer la reseña, si no esta registrado no puede hacer la reseña
    }
}