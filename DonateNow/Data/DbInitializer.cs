using DonateNow.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonateNow.Data
{
    public static class DbInitializer
    {
        public static void Initialize(DonateNowDataContext context)
        {

            // context.Database.Migrate();
            context.Database.EnsureCreated();

            //// Look for any students.
            //if (context.Donors.Any())
            //    return;   // DB has been seeded

            var donor = context.Donor.Where(g => g.DonorId == 0).FirstOrDefault();
            if (donor == null)
            {
#if DEBUG
                var donor1 = context.Add(new Donor
                { 
                    Name = "salim",
                    ConsentToPay = true,
                    PhysicalAddress = new PhysicalAddress { StreetNumber = 3541, Address1 = "Empire State Drive", City = "Canton", State = "MI", ZipCode = 48188 },
                    donationEvent = new List<DonationEvent> { new DonationEvent { DonationAmount = 20, DonationDate = DateTime.Now } },
                    paypal = new Paypal
                    {
                        paypalCredentials = new PaypalCredentials { PaypalEmail = "SALIMBHONHARIYA@GMAIL.COM", PaypalPassword = "123456" },
                    },
                    creditCards = new List<CreditCard>  { new CreditCard  { CardVerificationCode = 1234,CreditCardExpirationDate = DateTime.Now,CreditCardNumber = 1234567890, DonorId = 1, DonationEventId = 1 } }
                });
                context.SaveChanges();
            };

            //context.ServerSetting.Add(new ServerSetting()
            //{
            //    Id = "Auth0Domain",
            //    Value = "salimati.auth0.com"
            //});

            //context.ServerSetting.Add(new ServerSetting()
            //{
            //    Id = "Auth0ClientId",
            //    Value = "53DTgt80JDDwPFCJFsKzl3BqA7FHi8xx"
            //});

            //context.ServerSetting.Add(new ServerSetting()
            //{
            //    Id = "Auth0ClientSecret",
            //    Value = "xi7qQKjjTPQscQpXbj2D-Wcph6OVgB7BN1GGvja4JgKnNUtWkg7TT_3Cz5CWbdHW"
            //});

            //context.ServerSetting.Add(new ServerSetting()
            //{
            //    Id = "Auth0RedirectUri",
            //    Value = "http://localhost:51761/signin-auth0"
            //});
            //context.SaveChanges();

#endif
        }
    }
}



