﻿using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opts) : base(opts)
        {
               
        }

        public DbSet<Category> Categories { get; set; }

        ///Summary
        ///Seeds DB Table Using EFCore native tools

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Adventure", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Fantasy", DisplayOrder = 3 }
                );
        }
    }
}
