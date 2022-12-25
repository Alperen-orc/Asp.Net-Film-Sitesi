using Kod_1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kod_1.Models
{
    public class MovieComment
    {
        public Movie Movies { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Star> Stars { get; set; }

        public int StarValue { get; set; }
        public string comment { get; set; }
        public string Name { get; set; }
        public int MovieId { get; set; }
    }
}
