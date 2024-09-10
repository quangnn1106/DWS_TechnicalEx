using Microsoft.EntityFrameworkCore;
using SharedDomain.Entities.Movie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Infrastructure.Movies.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> contextOptions) : base(contextOptions)
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Award> Awards { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public DbSet<AwardSeasons> AwardSeasons { get; set; }
        public DbSet<AwardCategories> AwardCategories { get; set; }
        public DbSet<AwardActor> AwardActors { get; set; }
        public DbSet<AwardMovie> AwardMovies { get; set; }

        public DbSet<MovieActor> MovieActors { get; set; }
        public DbSet<MovieDirector> MovieDirectors { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }
    }
}
