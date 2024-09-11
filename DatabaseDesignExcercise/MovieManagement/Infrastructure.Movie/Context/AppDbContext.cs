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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Movie-Actor many-to-many relationship
            modelBuilder.Entity<MovieActor>()
                .HasKey(ma => new { ma.MovieId, ma.ActorId });
            modelBuilder.Entity<MovieActor>()
                .HasOne(ma => ma.Movie)
                .WithMany(m => m.MovieActors)
                .HasForeignKey(ma => ma.MovieId);
            modelBuilder.Entity<MovieActor>()
                .HasOne(ma => ma.Actor)
                .WithMany(a => a.MovieActors)
                .HasForeignKey(ma => ma.ActorId);

            // Movie-Director many-to-many relationship
            modelBuilder.Entity<MovieDirector>()
                .HasKey(md => new { md.MovieId, md.DirectorId });
            modelBuilder.Entity<MovieDirector>()
                .HasOne(md => md.Movie)
                .WithMany(m => m.MovieDirectors)
                .HasForeignKey(md => md.MovieId);
            modelBuilder.Entity<MovieDirector>()
                .HasOne(md => md.Director)
                .WithMany(d => d.MovieDirectors)
                .HasForeignKey(md => md.DirectorId);

            // Movie-Genre many-to-many relationship
            modelBuilder.Entity<MovieGenre>()
                .HasKey(mg => new { mg.MovieId, mg.GenreId });
            modelBuilder.Entity<MovieGenre>()
                .HasOne(mg => mg.Movie)
                .WithMany(m => m.MovieGenres)
                .HasForeignKey(mg => mg.MovieId);
            modelBuilder.Entity<MovieGenre>()
                .HasOne(mg => mg.Genre)
                .WithMany(g => g.MovieGenres)
                .HasForeignKey(mg => mg.GenreId);

            // Award-Actor many-to-many relationship
            modelBuilder.Entity<AwardActor>()
                .HasKey(aa => new { aa.AwardId, aa.ActorId });
            modelBuilder.Entity<AwardActor>()
                .HasOne(aa => aa.Award)
                .WithMany(a => a.AwardActors)
                .HasForeignKey(aa => aa.AwardId);
            modelBuilder.Entity<AwardActor>()
                .HasOne(aa => aa.Actor)
                .WithMany(a => a.AwardActors)
                .HasForeignKey(aa => aa.ActorId);

            // Award-Movie many-to-many relationship
            modelBuilder.Entity<AwardMovie>()
                .HasKey(am => new { am.AwardId, am.MovieId });
            modelBuilder.Entity<AwardMovie>()
                .HasOne(am => am.Award)
                .WithMany(a => a.AwardMovies)
                .HasForeignKey(am => am.AwardId);
            modelBuilder.Entity<AwardMovie>()
                .HasOne(am => am.Movie)
                .WithMany(m => m.AwardMovies)
                .HasForeignKey(am => am.MovieId);
        }
    }
}
