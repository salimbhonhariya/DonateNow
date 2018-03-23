using System.ComponentModel.DataAnnotations;

namespace DonateNow.Model
{
    public class PaypalCredentials: AuditedEntity
    {
        [Key]
        public int PaypalCredentialsId { get; set; }
        public string PaypalEmail { get; set; }
        public string PaypalPassword { get; set; }
    }
}