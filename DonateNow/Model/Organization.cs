using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DonateNow.Model
{
    public class Organization: AuditedEntity
    {
        [Key]
        //foreign key to organization
        public int OrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public PhysicalAddress Address { get; set; }
        public EventAddress eventAddress { get; set; }
    }
}
