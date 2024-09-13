using SharedDomain.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace SharedDomain.Entities.Movie
{
    public class AwardActor
    {
        [Key]
        public Guid ActorId { get; set; }
        public Actor? Actor { get; set; }

        [Key]
        public Guid AwardId { get; set; }
        public Award? Award { get; set; }

    }
}
