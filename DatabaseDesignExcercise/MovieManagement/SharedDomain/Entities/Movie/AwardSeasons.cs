using SharedDomain.Entities.Base;

namespace SharedDomain.Entities.Movie
{
    public class AwardSeasons : BaseEntity
    {
        public string? Name { get; set; }
        public DateTime Year { get; set; }
    }
}
