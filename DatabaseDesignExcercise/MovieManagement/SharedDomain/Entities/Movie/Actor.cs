using SharedDomain.Entities.Base;

namespace SharedDomain.Entities.Movie
{
    public class Actor: BaseEntity
    {
        public string? Name { get; set; }
        public string? Gender { get; set; }

        public ICollection<AwardActor>? AwardActors { get; set; }
        public ICollection<MovieActor>? MovieActors { get; set; }

    }
}
