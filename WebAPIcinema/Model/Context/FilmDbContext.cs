using Microsoft.EntityFrameworkCore;
using WebAPIcinema.Model.Entity;

namespace WebAPIcinema.Model.Context
{
    public class FilmDbContext : DbContext
    {
        public FilmDbContext(DbContextOptions<FilmDbContext> options) : base(options) {
        
        
        
        
        }

        public DbSet<Film> Film { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-ST8S73E\\SQLEXPRESS;Initial Catalog=SinemaVTabani;Integrated Security=True; TrustServerCertificate= True");

        }
    }
}
