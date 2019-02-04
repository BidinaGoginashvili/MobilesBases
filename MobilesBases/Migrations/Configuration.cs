namespace MobilesBases.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MobilesBases.Models;
    internal sealed class Configuration : DbMigrationsConfiguration<MobilesBases.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MobilesBases.Models.ApplicationDbContext context)
        {
            context.MF.AddOrUpdate(x => x.Id,
                new ManufacturerInformation() { Id = 1, ManufacturerName = "Huawei" },
                new ManufacturerInformation() { Id = 2, ManufacturerName = "Sony" },
                new ManufacturerInformation() { Id = 3, ManufacturerName = "Samsung" },
                new ManufacturerInformation() { Id = 4, ManufacturerName = "Iphone" },
                new ManufacturerInformation() { Id = 5, ManufacturerName = "LG" },
                new ManufacturerInformation() { Id = 5, ManufacturerName = "Nokia" }
            );
        }
    }
}
