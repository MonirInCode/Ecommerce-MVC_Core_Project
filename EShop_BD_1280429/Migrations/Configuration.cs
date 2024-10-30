namespace EShop_BD_1280429.Migrations
{
    using EShop_BD_1280429.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EShop_BD_1280429.Models.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EShop_BD_1280429.Models.AppDbContext context)
        {
            SeedData.Seed(context);
        }
    }
}
