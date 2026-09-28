namespace AppForSEII.API.Models
{
    public abstract class MetodoPago
    {
        public MetodoPago(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
        
    }
}