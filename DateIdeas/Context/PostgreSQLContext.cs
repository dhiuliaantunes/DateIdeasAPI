using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DateIdeas.Context
{
    public class PostgreSQLContext : DbContext
    {
        public DbSet<DateIdeas> DateIdeas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Database=dates;Port=5432;User Id=postgres;Password=123456;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DateIdeas>().HasData(
             new DateIdeas
             {
                 DateId = 1,
                 Date = "passear"

             },
             new DateIdeas
             {
                 DateId = 2,
                 Date = "comer"
             }
             );
        }
    }
}
