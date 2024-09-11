using SharedDomain.Entities.Base;

namespace SharedDomain.Entities.Movie
{
    public class MovieActor : BaseEntity
    {
        public Guid MovieId { get; set; }
        public Movie? Movie { get; set; }
        public Guid ActorId { get; set; }
        public Actor? Actor { get; set; }
    }
}

