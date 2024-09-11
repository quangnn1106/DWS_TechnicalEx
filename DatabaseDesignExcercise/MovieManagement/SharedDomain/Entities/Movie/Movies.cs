using SharedDomain.Entities.Base;

namespace SharedDomain.Entities.Movie
{
    public class Movie : BaseEntity
    {
        public string Name { get; set; }
        public DateTime YearOfRelease { get; set; }
        public ICollection<MovieActor>? MovieActors { get; set; }
        public ICollection<MovieDirector>? MovieDirectors { get; set; }
        public ICollection<MovieGenre>? MovieGenres { get; set; }
        public ICollection<AwardMovie>? AwardMovies { get; set; }
    }
}