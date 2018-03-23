using DonateNow.Data;
using System;

namespace DonateNow.Model
{
    public class AuditedEntity : IAuditedEntity
    {
        public DateTime CreatedAt { get; set; }

        public string CreatedBy { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public string LastModifiedBy { get; set; }
    }
}