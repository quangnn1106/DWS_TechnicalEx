using SharedDomain.Entities.Base;

namespace SharedDomain.Entities.Movie
{
    public class MovieGenre : BaseEntity
    {
        public Guid MovieId { get; set; }
        public Movie? Movie { get; set; }
        public Guid GenreId { get; set; }
        public Genre? Genre { get; set; }
    }
}
