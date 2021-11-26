using Microsoft.EntityFrameworkCore;
using EMigrante.App.Dominio;

namespace EMigrante.App.Persistencia
{
    public class AppContext: DbContext{
        public DbSet<Personas> Persona { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = EMigrante");
            }
        }
    }
}