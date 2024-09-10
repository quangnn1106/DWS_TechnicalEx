using SharedDomain.Entities.Base;

namespace SharedDomain.Entities.Movie
{
    public class MovieActor : BaseEntity
    {
        public Guid MovieId { get; set; }
        public Guid ActorId { get; set; }
        public ICollection<Movie>? Movies { get; set; }
        public ICollection<Actor>? Actors { get; set; }
    }
}
