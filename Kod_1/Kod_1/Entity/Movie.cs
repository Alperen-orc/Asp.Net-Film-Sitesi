using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kod_1.Entity
{
    public class Movie
    {
        public Movie()
        {
            Genres = new List<Genre>();
            Comments = new List<Comment>();
        }
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public List<Genre> Genres { get; set; }
        public List<Comment> Comments { get; set; }


    }
}
