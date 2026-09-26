namespace AppForSEII.API.Models
{
    public class Resena
    {
        public Resena(int id, DateTime fecharesena, string titulo, int usuarioId)
        {
            Id = id;
            Fecharesena = fecharesena;
            Titulo = titulo;
            UsuarioId = usuarioId;
        }
        public int Id{get;set;}

        [StringLength(20, MinimumLength = 10, ErrorMessage = "El título debe tener entre 10 y 20 caracteres.")]
        public string Titulo{get;set;}

        public int UsuarioId{get;set;}

        public DateTime Fecharesena{get;set;}
    }
}