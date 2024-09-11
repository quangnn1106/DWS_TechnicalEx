using SharedDomain.Entities.Base;

namespace SharedDomain.Entities.Movie
{
    public class Director: BaseEntity 
    {
        public string? Name { get; set; }
        public ICollection<MovieDirector>? MovieDirectors { get; set; }
    }
}
