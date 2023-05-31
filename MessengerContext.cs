using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMessenger
{
    internal class MessengerContext : DbContext
    {
        public DbSet<models.User> Users { get; set; }
        public DbSet<models.Message> Messages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=c_sharp_messenger;Username=postgres;Password=Colby5892;");
            base.OnConfiguring(optionsBuilder);
        }
        private const string CONNECTION_STRING = "Host=localhost;Port=5432;Database=c_sharp_messenger;Username=postgres;Password=Colby5892;";

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
