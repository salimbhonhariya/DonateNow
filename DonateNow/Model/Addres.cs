using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonateNow.Model
{
    public class Address : AuditedEntity, IAddress
    {
        int IAddress.AddressId { get; set; }
        int IAddress.StreetNumber { get; set; }
        string IAddress.Address1 { get; set; }
        string IAddress.Address2 { get; set; }
        string IAddress.City { get; set; }
        int IAddress.ZipCode { get; set; }
        string IAddress.Country { get; set; }
    }
}
