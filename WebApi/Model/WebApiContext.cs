using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection.Metadata;
using WebApi.Model.Entities;

namespace WebApi.Model
{
    /// <summary>
    /// DB context
    /// </summary>
    public class WebApiContext : DbContext
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="options"></param>
        public WebApiContext(DbContextOptions<WebApiContext> options) : base(options)
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public virtual DbSet<Product> Products { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
            .Property(b => b.Description)
            .IsRequired(false);
        }

        public void EnsureCreated()
        {
            try
            {
                if (Database.ProviderName != "Microsoft.EntityFrameworkCore.InMemory")
                {
                    Database.Migrate();
                }
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }
    }
}
