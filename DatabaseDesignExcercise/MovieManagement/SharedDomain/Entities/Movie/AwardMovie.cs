using SharedDomain.Entities.Base;

namespace SharedDomain.Entities.Movie
{
    public class AwardMovie : BaseEntity
    {
        public Guid MovieId { get; set; }
        public Guid AwardId { get; set; }
        public ICollection<Movie>? Movies { get; set; }
        public ICollection<Award>? Awards { get; }
    }
}
