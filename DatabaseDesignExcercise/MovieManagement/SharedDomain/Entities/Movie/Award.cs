using SharedDomain.Entities.Base;

namespace SharedDomain.Entities.Movie
{
    public class Award: BaseEntity
    {
        public string? Name { get; set; }
        public Guid SeasonId { get; set; }
        public AwardSeasons? Season { get; set; }
        public Guid CategoryId { get; set; }
        public AwardCategories? Category { get; set; }
        public ICollection<AwardActor>? AwardActors { get; set; }
        public ICollection<AwardMovie>? AwardMovies { get; set; }
    }
}
