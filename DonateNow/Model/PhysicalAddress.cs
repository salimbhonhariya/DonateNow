using System.ComponentModel.DataAnnotations;

namespace DonateNow.Model
{
    public class PhysicalAddress: AuditedEntity, IAddress
    {
        [Key]
        public int PhysicalAddressId { get; set; }
        public int AddressId { get; set; }
        public int StreetNumber { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string Country { get; set; }
    }
}