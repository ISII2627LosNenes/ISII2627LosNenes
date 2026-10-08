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
        
    }
}