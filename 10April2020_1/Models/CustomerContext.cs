using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace _10April2020_1.Models
{
    public class CustomerContext : DbContext
    {
        public CustomerContext([NotNullAttribute] DbContextOptions options) : base(options)
        { }

        public DbSet<Customer> Customer { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData
                (
             new Customer { CId = 1, CName = "Sameer", DOB = new DateTime(day: 10, month: 04, year: 2020), CPin = 1122 },
             new Customer { CId = 2, CName = "Zoya", DOB = new DateTime(day: 11, month: 04, year: 2020), CPin = 1111 },
             new Customer { CId = 3, CName = "Chetna", DOB = new DateTime(day: 12, month: 04, year: 2020), CPin = 2222 },
             new Customer { CId = 4, CName = "Kartik", DOB = new DateTime(day: 12, month: 05, year: 2020), CPin = 3322 }

                ); 
        }
    }
}
