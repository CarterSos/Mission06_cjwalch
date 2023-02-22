using Microsoft.EntityFrameworkCore;
using Mission06_cjwalch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DateMe.Models
{
    public class MovieFormContext : DbContext
    {
        // constructor
        public MovieFormContext(DbContextOptions<MovieFormContext> options) : base(options)
        {
            // leave blank for now
        }
        public DbSet<ApplicationResponse> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        // Seed Data
        protected override void OnModelCreating(ModelBuilder mb)
        {

            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Action" },
                new Category { CategoryId = 2, CategoryName = "Adventure" },
                new Category { CategoryId = 3, CategoryName = "Drama" },
                new Category { CategoryId = 4, CategoryName = "Comedy" },
                new Category { CategoryId = 5, CategoryName = "Romance" }
                );


            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                {
                    Title = "Avengers: Endgame",
                    CategoryId = 1,
                    Year = 2019,
                    Director = "Russo Brothers",
                    Rating = "PG-13",
                    Notes = "Greatest Movie ever"
                },
                new ApplicationResponse
                {
                    Title = "Spiderman: Into the Spider-verse",
                    CategoryId = 1,
                    Year = 2018,
                    Director = "Bob Persichetti",
                    Rating = "PG"
                },
                new ApplicationResponse
                {
                    Title = "The Count of Monte Cristo",
                    CategoryId = 2,
                    Year = 2002,
                    Director = "Kevin Reynolds",
                    Rating = "PG-13",
                    Notes = "Best revenge story"
                }

            );
        }
    }
}
