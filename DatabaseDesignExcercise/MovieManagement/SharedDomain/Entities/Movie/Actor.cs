using SharedDomain.Entities.Base;

namespace SharedDomain.Entities.Movie
{
    public class Actor: BaseEntity
    {
        public string? Name { get; set; }
        public string? Gender { get; set; }
    }
}
