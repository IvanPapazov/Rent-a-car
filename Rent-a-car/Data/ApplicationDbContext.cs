using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Rent_a_car.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rent_a_car.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUsers>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies();
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AppUsers>()
                .HasIndex(u => u.EGN)
                .IsUnique();

            builder.Entity<AppUsers>()
                .HasIndex(u => u.EGN)
                .IsUnique();
        }
    }
}
