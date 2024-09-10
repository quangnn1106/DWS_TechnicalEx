using SharedDomain.Entities.Base;

namespace SharedDomain.Entities.Movie
{
    public class Movie : BaseEntity
    {
        public string? Name { get; set; }
        public DateTime YearOfRelease { get; set; }
    }
}
