namespace AppForSEII.API.Models
{
    public class Resena
    {
        public Resena()
        {
            ResenaItems = new List<ResenaItem>();
        }
        public Resena(int id, DateTime fecharesena, string titulo, IList<ResenaItem> resenaItems)
        {
            Id = id;
            Fecharesena = fecharesena;
            Titulo = titulo;
            ResenaItems = resenaItems;
         
        }
        public int Id{get;set;}

        [StringLength(20, MinimumLength = 10, ErrorMessage = "El título debe tener entre 10 y 20 caracteres.")]
        public string Titulo{get;set;}

        

        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Fecharesena{get;set;}

        public IList<ResenaItem> ResenaItems { get; set; }
    }
}