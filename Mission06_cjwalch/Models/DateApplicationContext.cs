using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DateMe.Models
{
    public class DateApplicationContext : DbContext
    {
        // constructor
        public DateApplicationContext(DbContextOptions<DateApplicationContext> options) : base(options)
        {
            // leave blank for now
        }
        public DbSet<ApplicationResponse> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                {
                    Title = "Avengers: Endgame",
                    Category = "Action",
                    Year = 2019,
                    Director = "Russo Brothers",
                    Rating = "PG-13",
                    Notes = "Greatest Movie ever"
                },
                new ApplicationResponse
                {
                    Title = "Spiderman: Into the Spider-verse",
                    Category = "Action",
                    Year = 2018,
                    Director = "Bob Persichetti",
                    Rating = "PG"
                },
                new ApplicationResponse
                {
                    Title = "The Count of Monte Cristo",
                    Category = "Adventure",
                    Year = 2002,
                    Director = "Kevin Reynolds",
                    Rating = "PG-13",
                    Notes = "Best revenge story"
                }

            );
        }
    }
}
