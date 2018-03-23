using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DonateNow.Model
{
    public class DonationEvent: AuditedEntity
    {
        [Key]
        public int DonationEventId {get;set;}
        public DateTime DonationDate { get; set; }
        public decimal DonationAmount { get; set; }
        public Organization Organization { get; set; }
        [ForeignKey("Donor")]
        public int DonorId { get; set; }
    }
}