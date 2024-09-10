using SharedDomain.Entities.Base;

namespace SharedDomain.Entities.Movie
{
    public class MovieGenre : BaseEntity
    {
        public Guid MovieId { get; set; }
        public Guid GenreId { get; set; }
        public ICollection<Movie>? Movies { get; set; }
        public ICollection<Genre>? Genres { get; set; }
    }
}
