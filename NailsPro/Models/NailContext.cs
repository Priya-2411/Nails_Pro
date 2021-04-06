using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;


namespace NailsPro.Models
{
    public class NailContext : DbContext
    {

        public NailContext(DbContextOptions<NailContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Staff> Staffs { get; set; }

        protected virtual void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
            {
            modelBuilder.Entity<Customer>()
                    .Property(e => e.FirstName)
                    .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.TelNumber)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Address)
                .IsUnicode(false);


            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Bookings)
                .WithRequired(e => e.Customer)
                .HasForeignKey(e => e.CustomerId)
                .WillCascadeOnDelete(false);


            modelBuilder.Entity<Staff>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.Phone)
                .IsUnicode(false);

        

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.Bookings)
                .WithRequired(e => e.Staff)
                .WillCascadeOnDelete(false);
        }

    }
}
