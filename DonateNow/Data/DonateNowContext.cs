using DonateNow.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonateNow.Data
{
    public class DonateNowDataContext : IdentityDbContext<ApplicationUser> //DbContext
    {
        public DonateNowDataContext(DbContextOptions<DonateNowDataContext> options) : base(options)
        {
        }
        public override int SaveChanges()
        {
            var addedAuditedEntities = ChangeTracker.Entries<IAuditedEntity>()
             .Where(p => p.State == EntityState.Added)
             .Select(p => p.Entity);

            var modifiedAuditedEntities = ChangeTracker.Entries<IAuditedEntity>()
              .Where(p => p.State == EntityState.Modified)
              .Select(p => p.Entity);
            var now = DateTime.UtcNow;
            foreach (var added in addedAuditedEntities)
            {
                added.CreatedAt = now;
                added.LastModifiedAt = now;
            }

            foreach (var modified in modifiedAuditedEntities)
            {
                modified.LastModifiedAt = now;
            }
            var result = base.SaveChanges();
            return result;
        }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);


            //modelbuilder.Entity<Donor>()
            //  .HasMany(ug => ug.creditCards)
            //  .WithOne(gp => gp.Donor)
            //  .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Cascade);


            //modelbuilder.Entity<Donor>()
            //  .HasMany(ug => ug.donationEvent)
            //  .WithOne(gp => gp.Donor)
            //  .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Cascade);
        }
        public virtual DbSet<Donor> Donor { get; set; }
        public virtual DbSet<CreditCard> creditCard { get; set; }
        public virtual DbSet<DonationEvent> donationEvent{ get; set; }
        public virtual DbSet<EventAddress> eventAddresse { get; set; }
        public virtual DbSet<MailingAddress> MailingAddresse { get; set; }
        public virtual DbSet<Paypal> paypal { get; set; }
        public virtual DbSet<Organization> Organization { get; set; }

        public virtual DbSet<ServerSetting> ServerSetting { get; set; }
        

    }
}
