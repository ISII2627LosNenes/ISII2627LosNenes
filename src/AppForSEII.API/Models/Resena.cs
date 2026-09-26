namespace AppForSEII.API.Models
{
    public class Resena
    {
        public Resena(int id, DateTime fecharesena, string titulo)
        {
            Id = id;
            Fecharesena = fecharesena;
            Titulo = titulo;
         
        }
        public int Id{get;set;}

        [StringLength(20, MinimumLength = 10, ErrorMessage = "El título debe tener entre 10 y 20 caracteres.")]
        public string Titulo{get;set;}

        

        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Fecharesena{get;set;}
    }
}