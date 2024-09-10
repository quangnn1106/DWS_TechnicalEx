using SharedDomain.Entities.Base;

namespace SharedDomain.Entities.Movie
{
    public class AwardActor: BaseEntity
    {
        public Guid ActorId { get; set; }
        public Guid AwardId { get; set; }
        public ICollection<Actor>? Actors { get; set;}
        public ICollection<Award>? Awards { get;}

    }
}
