using System.ComponentModel.DataAnnotations;

namespace DonateNow.Model
{
    public class Paypal : AuditedEntity
    {
        [Key]
        public int PaypalId { get; set; }
        public PaypalCredentials paypalCredentials { get; set; }
    }
}