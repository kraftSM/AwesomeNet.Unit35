﻿using AwesomeNet.Unit35.Configs;
using AwesomeNet.Unit35.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;


namespace AwesomeNet.Unit35.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated(); 
            //Database.Migrate();

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<IdentityUser>()
                .ToTable("AspNetUsers", t => t.ExcludeFromMigrations()); 
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new FriendConfiguration());
            builder.ApplyConfiguration(new MessageConfuiguration());
            
        }
    }
}
