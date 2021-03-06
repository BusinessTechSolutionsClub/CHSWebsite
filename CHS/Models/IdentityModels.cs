﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CHS.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }


        //Adding tables to the database
        public DbSet<User> Users1 { get; set; }
        public DbSet<HoursOfOperation> HoursOfOperations { get; set; }
        public DbSet<Product> Products { get; set; }
        public System.Data.Entity.DbSet<CHS.Models.AboutUs> AboutUs { get; set; }
        public System.Data.Entity.DbSet<CHS.Models.HomePage> HomePages { get; set; }
        public System.Data.Entity.DbSet<CHS.Models.Service> Services { get; set; }

        public System.Data.Entity.DbSet<CHS.Models.ContactUs> ContactUs { get; set; }
    }
}