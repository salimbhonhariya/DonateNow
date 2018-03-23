using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DonateNow.Model
{
    public class CreditCard: AuditedEntity
    {
        [Key]
        public int CreditCardId { get; set; }
        public string NameAppearOnCard { get; set; }
        public int CreditCardNumber { get; set; }
        public DateTime CreditCardExpirationDate { get; set; }
        public int CardVerificationCode { get; set; }
        public MailingAddress mailingAddress { get; set; }

        [ForeignKey("Donor")]
        public int DonorId { get; set; }
        [ForeignKey("DonorEvent")]
        public int DonationEventId { get; set; }
    }
}
