using Microsoft.EntityFrameworkCore;
using System;

        public class ApplicationContext : DbContext
        {
            public DbSet<account> account { get; set; } = null!;
            public DbSet<products> products  { get; set; } = null!;

            public ApplicationContext()
            {
                Database.EnsureCreated();
            }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=vet_apteka;Username=postgres;Password=12qw23as34zx");
            }
        }