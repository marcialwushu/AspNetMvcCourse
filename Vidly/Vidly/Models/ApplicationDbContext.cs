using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MembershipType> MembershipType { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Rental> Rentals { get; set; }


        public ApplicationDbContext() 
        {

        }

        
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}