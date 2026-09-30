namespace AppForSEII.API.Models
{
    public class Resena
    {
        public Resena()
        {
            ResenaItems = new List<ResenaItem>();
        }
        public Resena(int id, DateTime fecharesena, string titulo, IList<ResenaItem> resenaItems, ApplicationUser cliente)
        {
            Id = id;
            Fecharesena = fecharesena;
            Titulo = titulo;
            ResenaItems = resenaItems;
            Cliente = cliente;
         
        }
        public int Id{get;set;}

        [StringLength(20, MinimumLength = 10, ErrorMessage = "El título debe tener entre 10 y 20 caracteres.")]
        public string Titulo{get;set;}

        

        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Fecharesena{get;set;}

        public IList<ResenaItem> ResenaItems { get; set; }

        public  ApplicationUser Cliente { get; set; } //Para ver que este el usuario registrado y que pueda hacer la reseña, si no esta registrado no puede hacer la reseña
    }
}