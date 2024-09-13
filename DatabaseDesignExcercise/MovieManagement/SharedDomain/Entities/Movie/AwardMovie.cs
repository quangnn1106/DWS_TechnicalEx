using SharedDomain.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace SharedDomain.Entities.Movie
{
    public class AwardMovie
    {
        [Key]
        public Guid MovieId { get; set; }
        public Movie? Movie { get; set; }
        [Key]
        public Guid AwardId { get; set; }
        public Award? Award { get; set; }
    }
}
