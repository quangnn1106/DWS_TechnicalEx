﻿using SharedDomain.Entities.Base;

namespace SharedDomain.Entities.Movie
{
    public class Genre : BaseEntity
    {
        public string? Name { get; set; }
        public ICollection<MovieGenre>? MovieGenres { get; set; }
    }
}
