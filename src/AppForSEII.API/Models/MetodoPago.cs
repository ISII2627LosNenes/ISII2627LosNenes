namespace AppForSEII.API.Models
{
    public abstract class MetodoPago
    {
        public MetodoPago(int id)
        {
            Id = id;
        }
        public MetodoPago()
        {
        }

        [Key]
        public int Id { get; set; }

        public IList<Compra> Compras { get; set; } = new List<Compra>();
        public IList<Reposicion> Reposiciones { get; set; } = new List<Reposicion>();

        public IList<Subasta> Subastas { get; set; } = new List<Subasta>();
    }
}