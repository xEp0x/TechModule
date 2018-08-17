namespace CSharp_Blog.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<CSharp_Blog.Models.BlogDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "CSharp_Blog.Models.BlogDbContext";
        }

        protected override void Seed(CSharp_Blog.Models.BlogDbContext context)
        {

        }
    }
}
