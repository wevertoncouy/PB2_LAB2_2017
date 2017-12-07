using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace WebApProva2Lab2WevertonCouy.Models
{
    public class ProtocoloContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ProtocoloContext() : base("name=ProtocoloContext")
        {
        }

        public System.Data.Entity.DbSet<WebApProva2Lab2WevertonCouy.Models.Aluno> Alunoes { get; set; }

        public System.Data.Entity.DbSet<WebApProva2Lab2WevertonCouy.Models.Endereco> Enderecoes { get; set; }

        public System.Data.Entity.DbSet<WebApProva2Lab2WevertonCouy.Models.Protocolo> Protocoloes { get; set; }

        public System.Data.Entity.DbSet<WebApProva2Lab2WevertonCouy.Models.Tramite> Tramites { get; set; }

        public System.Data.Entity.DbSet<WebApProva2Lab2WevertonCouy.Models.Historico> Historicoes { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();


            modelBuilder.Properties<DateTime>()
               .Configure(p => p.HasColumnType("datetime2"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(200));

            modelBuilder.Properties<string>()
        .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Types()
               .Configure(t => t.MapToStoredProcedures());





        }





    }
}
