using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kod_1.Entity
{
        public class Comment
        {
            public int CommentId { get; set; }
            [Required(ErrorMessage ="Ad alanı zorunludur")]
            public string Name { get; set; }
            [Required(ErrorMessage ="Yorum alanı zorunludur")]
            public string comment { get; set; }
            public Movie Movies { get; set; }
            public int MovieId { get; set; }

    }
}
