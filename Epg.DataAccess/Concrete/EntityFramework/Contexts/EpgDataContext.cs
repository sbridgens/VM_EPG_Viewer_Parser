using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;

namespace Epg.DataAccess.Concrete.EntityFramework.Contexts
{
    public class EpgDataContext : DbContext
    {
        
        public EpgDataContext() { }

        public EpgDataContext(DbContextOptions<EpgDataContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
                return;


            optionsBuilder.UseMySQL("server=localhost;database=library;user=user;password=password");


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

        }
    }
}

//https://dev.mysql.com/doc/connector-net/en/connector-net-entityframework-core-example.html
//https://docs.microsoft.com/en-us/ef/core/what-is-new/ef-core-5.0/whatsnew
//Last item : https://stackoverflow.com/questions/40234615/system-data-entity-modelconfiguration-missing-in-ef-core
