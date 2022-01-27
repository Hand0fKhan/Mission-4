using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class MovieContext: DbContext
    {
        public MovieContext (DbContextOptions<MovieContext> options) : base(options)
        {

        }

        public DbSet<ApplicationResponse> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                {
                    MovieID = 1,
                    Rating = "PG-13",
                    Edit = false,
                    LentTo = "",
                    Notes = "",
                    Category = "Science Fantasy",
                    Title = "Rogue One: A Star Wars Story",
                    Year = "2016",
                    Director = "Gareth Edwards"
                },
                new ApplicationResponse
                {
                    MovieID = 2,
                    Rating = "PG-13",
                    Edit = false,
                    LentTo = "",
                    Notes = "",
                    Category = "Science Fantasy",
                    Title = "Star Wars: Empire Strikes Back",
                    Year = "1980",
                    Director = "Irvin Kershner"
                },
                new ApplicationResponse
                {
                    MovieID = 3,
                    Rating = "PG",
                    Edit = false,
                    LentTo = "",
                    Notes = "",
                    Category = "Fantasy",
                    Title = "How to Train Your Dragon",
                    Year = "2010",
                    Director = "Chris Sanders"
                }
            ) ;
        }
    }
}
