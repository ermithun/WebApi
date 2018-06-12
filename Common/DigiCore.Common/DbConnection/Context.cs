using DigiCore.Entities.Enum;
using DigiCore.Entities.CoreManagement;
using DigiCore.Entities.StockManagement.Models;
using DigiCore.Entities.UserManagement.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using DigiCore.Entities.CoreManagement.Models;


namespace DigiCore.Common.DbConnection
{
    public class Context : IdentityDbContext<ApplicationUser, ApplicationRole, int>
    {
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }


        public IConfigurationRoot Configuration { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = configuration.Build();


            string conStr = Configuration.GetConnectionString("DefaultConnection");
            if (string.IsNullOrEmpty(conStr))
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-IIVRUH6; Database=WebApi; uid=sa; pwd=mithun; MultipleActiveResultSets=true; Trusted_Connection=True; Connection Timeout=100;Integrated Security=false");
            }
            else
            {
                optionsBuilder.UseSqlServer(conStr);
            }
        }

        public async void EnsureSeedData(UserManager<ApplicationUser> userMgr, RoleManager<ApplicationRole> roleMgr)
        {
            if (!this.Users.Any(u => u.UserName == "Admin"))
            {
                // create system user
                var systemUser = new ApplicationUser();
                systemUser.UserName = "Admin";
                systemUser.Email = "";
                systemUser.PhoneNumber = "";
                systemUser.IsActive = true;
                systemUser.IsSystemUser = true;
                systemUser.AddedBy = 1;
                systemUser.AddedOn = DateTime.Today;
                systemUser.Status = RowStatus.Approved;
                systemUser.UpdatedBy = 1;
                systemUser.UpdatedOn = DateTime.Now;
                systemUser.LockoutEnabled = true;
                systemUser.LockoutEnd = DateTime.MaxValue;
                await userMgr.CreateAsync(systemUser, "Mithun@123");

            }
        }

        //UserMgmt
        public DbSet<ApplicationUser> AspNetUsers { get; set; }
        public DbSet<ApplicationRole> AspNetRoles { get; set; }
        public DbSet<ApplicationUserToken> AspNetUserToken { get; set; }
        public DbSet<UserLoginHist> UserLoginHist { get; set; }
        public DbSet<UserRoleMap> UserRoleMap { get; set; }


        //GlobalMgmt

        public DbSet<Module> Module { get; set; }   //AutoFeed
      
        public DbSet<ExceptionLog> ExceptionLog { get; set; }
    



        //StockMgmt
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }

    }
}
