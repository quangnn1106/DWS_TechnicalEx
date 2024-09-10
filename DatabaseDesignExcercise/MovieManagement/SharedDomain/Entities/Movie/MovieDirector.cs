using SharedDomain.Entities.Base;

namespace SharedDomain.Entities.Movie
{
    public class MovieDirector: BaseEntity
    {
        public Guid MovieId { get; set; }
        public Guid DirectorId { get; set; }
        public ICollection<Movie>? Movies { get; set; }
        public ICollection<Director>? Directors { get; set;}
    }
}
