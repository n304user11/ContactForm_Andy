using ContactForm_Andy.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactForm_Andy.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;TrustServerCertificate=true;");
        }

        public DbSet<ContactForm> ContactForms { get; set; }
    }
}
