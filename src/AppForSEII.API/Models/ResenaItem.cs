namespace AppForSEII.API.Models
{
    [PrimaryKey(nameof(LibroId), nameof(ResenaId))]
    public class ResenaItem
    {
        public ResenaItem(int id, int calificacion, string descricion, int libroId, int resenaId)
        {
            Id = id;
            Descripcion = descricion;
            Calificacion = calificacion;
            LibroId = libroId;
            ResenaId = resenaId;
         
        }

        public int Id{get;set;}
        public int LibroId{get;set;}

        public int ResenaId{get;set;}

        [StringLength(100, MinimumLength = 20, ErrorMessage = "La descricion tiene que tener entre 20 y 100 caracteres")]
        public string ? Descripcion{get;set;}

        

        [Range(1,5, ErrorMessage = "Calificación media tiene que estar entre 1 y 5")]
        public int Calificacion{get;set;}
    }
}
