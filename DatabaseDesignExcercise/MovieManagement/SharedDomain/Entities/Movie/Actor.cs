using SharedDomain.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace SharedDomain.Entities.Movie
{
    public class Actor: BaseEntity
    {
        [MaxLength(100)]
        public string? Name { get; set; }
        public string? Gender { get; set; }

        public ICollection<AwardActor>? AwardActors { get; set; }
        public ICollection<MovieActor>? MovieActors { get; set; }

    }
}
