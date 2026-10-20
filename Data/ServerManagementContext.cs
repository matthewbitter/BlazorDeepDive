using BlazorDeepDive.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorDeepDive.Data
{
    public class ServerManagementContext : DbContext
    {

        public ServerManagementContext(DbContextOptions<ServerManagementContext> options) : base(options)
        {
            // Ensure the database is created and apply any pending migrations automatically. This is useful for development and testing scenarios.
        }

        public DbSet<Server> Servers { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Server>().HasData(
                new Server
                {
                    ServerId = 1,
                    Name = "Server 1",
                    City = "New York",
                    IsOnline = true
                },
                new Server
                {
                    ServerId = 2,
                    Name = "Server 2",
                    City = "Los Angeles",
                    IsOnline = false
                },
                new Server
                {
                    ServerId = 3,
                    Name = "Server 3",
                    City = "Chicago",
                    IsOnline = true
                }
            );

        }

    }
}
