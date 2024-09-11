using SharedDomain.Entities.Base;

namespace SharedDomain.Entities.Movie
{
    public class AwardMovie : BaseEntity
    {
        public Guid MovieId { get; set; }
        public Movie? Movie { get; set; }
        public Guid AwardId { get; set; }
        public Award? Award { get; set; }
    }
}
