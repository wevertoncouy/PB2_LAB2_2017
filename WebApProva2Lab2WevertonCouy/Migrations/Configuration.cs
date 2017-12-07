namespace WebApProva2Lab2WevertonCouy.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApProva2Lab2WevertonCouy.Models.ProtocoloContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WebApProva2Lab2WevertonCouy.Models.ProtocoloContext context)
        {
            
        }
    }
}
