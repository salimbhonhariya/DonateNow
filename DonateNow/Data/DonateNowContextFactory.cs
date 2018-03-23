//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Design;
//using Microsoft.Extensions.Configuration;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace DonateNow.Data
//{
//    public class DonateNowContextFactory : IDesignTimeDbContextFactory<DonateNowDataContext>

//    {
//        public DonateNowDataContext CreateDbContext(string[] args)
//        {
//            //var optionsBuilder = new DbContextOptionsBuilder<DonateNowDataContext>();
//            IConfigurationRoot configuration = new ConfigurationBuilder()
//            .SetBasePath(System.IO.Directory.GetCurrentDirectory())
//            .AddJsonFile("appsettings.json")
//            .Build();
//            var builder = new DbContextOptionsBuilder<DonateNowDataContext>();
//            var connectionString = configuration.GetConnectionString("DefaultConnection");
//            builder.UseSqlServer(connectionString);
//            return new DonateNowDataContext(builder.Options);


//        }
//    }
//}
