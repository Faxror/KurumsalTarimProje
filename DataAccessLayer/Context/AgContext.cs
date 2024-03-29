﻿using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public class AgContext : IdentityDbContext  
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=Eriza-Studio;database=DbTarim; Integrated security=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adress>().HasNoKey();
            modelBuilder.Entity<SocialMedia>().HasNoKey();
            modelBuilder.Entity<IdentityUserLogin< string>>().HasNoKey();
            modelBuilder.Entity<IdentityUserRole< string>>().HasNoKey();
            modelBuilder.Entity<IdentityUserToken< string>>().HasNoKey();


        }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Annoncement> Annoncements { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
