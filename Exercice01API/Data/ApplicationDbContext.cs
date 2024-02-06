using Exercice01API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Exercice01API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



            modelBuilder.Entity<Contact>().HasData(
                new Contact { Id = 1, FirstName = "Jean ", LastName = " Dakd", Password = " ICOZJQI", AvatarURL = " URL1 ", Phone = "07112562", Email = "Jean.Dakd@gmail.com" },
                new Contact { Id = 2, FirstName = "Alfred ", LastName = "aziod", Password = " QZCNQj", AvatarURL = " URL 2", Phone = "0658421895", Email = "Alfred.aziod@gmail.com" },
                new Contact { Id = 3, FirstName = "Nicolas ", LastName = "oczz", Password = " KOQVN?QKkd", AvatarURL = " URL 3", Phone = "0715289173", Email = "Nicolas.oczz@gmail.com" }
            );
        }
    }
}

