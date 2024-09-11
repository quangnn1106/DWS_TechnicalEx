using SharedDomain.Entities.Base;

namespace SharedDomain.Entities.Movie
{
    public class MovieDirector: BaseEntity
    {
        public Guid MovieId { get; set; }
        public Movie? Movie { get; set; }
        public Guid DirectorId { get; set; }
        public Director? Director { get; set; }
    }
}
