using SharedDomain.Entities.Base;

namespace SharedDomain.Entities.Movie
{
    public class AwardActor: BaseEntity
    {
        public Guid ActorId { get; set; }
        public Actor? Actor { get; set; }
        public Guid AwardId { get; set; }
        public Award? Award { get; set; }

    }
}
