namespace AppForSEII.API.Models
{
    public class Paypal : MetodoPago
    {
        public Paypal(string numeroTelefono) : base()
        {
            NumeroTelefono = numeroTelefono;
        }
        
        public string NumeroTelefono { get; set; }
    }
}