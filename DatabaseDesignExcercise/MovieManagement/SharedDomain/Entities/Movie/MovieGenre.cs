using SharedDomain.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace SharedDomain.Entities.Movie
{
    public class MovieGenre
    {
        [Key]
        public Guid MovieId { get; set; }
        public Movie? Movie { get; set; }

        [Key]
        public Guid GenreId { get; set; }
        public Genre? Genre { get; set; }
    }
}
