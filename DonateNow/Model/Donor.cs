using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DonateNow.Model
{
    public class Donor : AuditedEntity
    {
        [Key]
        public int DonorId { get; set; }
        public string Name { get; set; }
        public bool ConsentToPay { get; set; }
        public Paypal paypal { get; set; }
        public PhysicalAddress PhysicalAddress { get; set; }
        // one-to-many-relationship with foreign key to donationevent table
        public ICollection<DonationEvent> donationEvent { get; set; }
        // one-to-many-relationship with foreign key to creditcard table
        public ICollection<CreditCard> creditCards { get; set; }
    }
}
