namespace AppForSEII.API.Models
{
    public class Visa : MetodoPago
    {
        public Visa(string numeroTarjeta, string fechaCaducidad) : base()
        {
            NumeroTarjeta = numeroTarjeta;
            FechaVencimiento = fechaCaducidad;
        }

        public string NumeroTarjeta { get; set; }
        public string FechaVencimiento { get; set; }
        
    }
}