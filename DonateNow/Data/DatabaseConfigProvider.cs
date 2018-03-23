using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonateNow.Data
{
    public class DatabaseConfigProvider : ConfigurationProvider, IDesignTimeDbContextFactory<DonateNowDataContext>
    {
        public DatabaseConfigProvider(Action<DbContextOptionsBuilder> optionsAction)
        {
            OptionsAction = optionsAction;
        }

        Action<DbContextOptionsBuilder> OptionsAction { get; }

        public DonateNowDataContext CreateDbContext(string[] args)
        {
            throw new NotImplementedException();
        }

        // Load config data from EF DB.
        public override void Load()
        {
            var builder = new DbContextOptionsBuilder<DonateNowDataContext>();
            OptionsAction(builder);
            using (var dbContext = new DonateNowDataContext(builder.Options))
            {
                //dbContext.Database.Migrate();
               dbContext.Database.EnsureCreated();
                Data = dbContext.ServerSetting.ToDictionary(c => c.Id, c => c.Value);
            }
        }

    }
}
