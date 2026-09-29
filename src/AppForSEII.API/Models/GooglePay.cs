namespace AppForSEII.API.Models
{
    public class GooglePay : MetodoPago
    {
        public GooglePay(string email) : base()
        {
            Email=email;
            
        }

        public string Email { get; set; }
       
    }
}