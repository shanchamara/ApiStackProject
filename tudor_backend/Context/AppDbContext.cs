using Microsoft.EntityFrameworkCore;
using tudor_backend.DatabaseConnection;

namespace tudor_backend.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                //optionsBuilder.UseMySQL("Server=DESKTOP-E44PHHS;Database=TudorApp;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;");
                optionsBuilder.UseMySql("server=database-1.ch0rr6yrhyox.ap-southeast-1.rds.amazonaws.com;User Id=admin;password=fliVeRloPCoP;database=TudorAudit;persistsecurityinfo=True;convert zero datetime=True;", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.14-mariadb"));

            }
        }


        public DbSet<TblClient_Contact_Person> TblClient_Contact_Person { get; set; }




        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


        }



    }
}
