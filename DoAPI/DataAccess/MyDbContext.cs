using System.Collections.Generic;
using DoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DoAPI.DataAccess
{
    public class MyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Family> Families { get; set; }
        public DbSet<Adult> Adults { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Hobby> Hobby { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = data.db");
        }
        
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}