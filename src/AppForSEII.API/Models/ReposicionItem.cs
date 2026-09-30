namespace AppForSEII.API.Models
{
    
    public class ReposicionItem
    {
        public ReposicionItem(Reposicion reposicion,  int cantidadReposicion, Libro libro)
        {
            ReposicionId = reposicion.Id;
            CantidadReposicion = cantidadReposicion;
            LibroId = libro.Id;
            Libro = libro;
            Reposicion = reposicion;
        }
        [Range(2, int.MaxValue, ErrorMessage = "La cantidad de reposición debe ser mayor a 1")]
        public int CantidadReposicion { get; set; }
        public int ReposicionId { get; set; }
        public int LibroId { get; set; }
        public Libro Libro { get; set; }
        public Reposicion Reposicion { get; set; }

    }
}