using SharedDomain.Entities.Base;

namespace SharedDomain.Entities.Movie
{
    public class Award: BaseEntity
    {
        public string? Name { get; set; }
        public Guid SeasonId { get; set; }
        public ICollection<AwardSeasons>? Seasons { get; set; }
        public Guid CategoryId { get; set; }
        public ICollection<AwardCategories>? Categories { get; set; }
    }
}
