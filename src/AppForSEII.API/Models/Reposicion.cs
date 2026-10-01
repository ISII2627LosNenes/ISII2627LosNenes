namespace AppForSEII.API.Models
{
    public class Reposicion
    {
        public Reposicion()
        {
            ReposicionItems = new List<ReposicionItem>();
        }
        public Reposicion(int id, DateTime fechaReposicion, decimal precioTotal, string comentario, ApplicationUser admin, IList<ReposicionItem> reposicionItems)
        {
            Id = id;
            FechaReposicion = fechaReposicion;
            PrecioTotal = precioTotal;
            Comentario = comentario;
            Admin = admin;
            ReposicionItems = reposicionItems;
        }
        public int Id { get; set; }
        
        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaReposicion { get; set; }
        public decimal PrecioTotal { get; set; }
        [StringLength(100, MinimumLength = 20, ErrorMessage = "El comentario debe tener entre 20 y 100 caracteres.")]
        public string? Comentario { get; set; }
        public IList<ReposicionItem> ReposicionItems { get; set; }

        public  ApplicationUser Admin { get; set; } 
    }
}