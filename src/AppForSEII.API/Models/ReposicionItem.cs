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
        
        public int CantidadReposicion { get; set; }
        public int ReposicionId { get; set; }
        public int LibroId { get; set; }
        public Libro Libro { get; set; }
        public Reposicion Reposicion { get; set; }

    }
}