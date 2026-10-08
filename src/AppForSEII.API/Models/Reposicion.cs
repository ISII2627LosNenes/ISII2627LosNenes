namespace AppForSEII.API.Models
{
    public class Reposicion
    {
        public Reposicion()
        {
            ReposicionItems = new List<ReposicionItem>();
        }
        public Reposicion(int id,string titulo,string nombre, string papellido, string sapellido, string telefono, MetodoPago metodoPago, DateTime fechaReposicion, decimal precioTotal, string comentario, ApplicationUser admin, IList<ReposicionItem> reposicionItems)
        {
            Id = id;
            Titulo = titulo;
            Nombre = nombre;
            Papellido = papellido;
            Sapellido = sapellido;
            Telefono = telefono;
            MetodoPago = metodoPago;
            FechaReposicion = fechaReposicion;
            PrecioTotal = precioTotal;
            Comentario = comentario;
            Admin = admin;
            ReposicionItems = reposicionItems;
        }
        [Key]
        public int Id { get; set; }
        
        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaReposicion { get; set; }
        public decimal PrecioTotal { get; set; }
        [StringLength(100, MinimumLength = 20, ErrorMessage = "El comentario debe tener entre 20 y 100 caracteres.")]
        public string? Comentario { get; set; }

        [Required(ErrorMessage = "El título es obligatorio.")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El primer apellido es obligatorio.")]
        public string Papellido { get; set; }
        [Required(ErrorMessage = "El segundo apellido es obligatorio.")]
        public string Sapellido { get; set; }
        [Required(ErrorMessage = "El teléfono es obligatorio.")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "El método de pago es obligatorio.")]
        public MetodoPago MetodoPago { get; set; }

        public IList<ReposicionItem> ReposicionItems { get; set; }

        public  ApplicationUser Admin { get; set; } 
    }
}