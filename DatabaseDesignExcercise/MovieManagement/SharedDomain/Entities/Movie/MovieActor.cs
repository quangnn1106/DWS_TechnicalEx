using SharedDomain.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace SharedDomain.Entities.Movie
{
    public class MovieActor
    {
        [Key]
        public Guid MovieId { get; set; }
        public Movie? Movie { get; set; }
        [Key]
        public Guid ActorId { get; set; }
        public Actor? Actor { get; set; }
    }
}

