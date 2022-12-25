using Kod_1.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kod_1.Models
{
    public class CommentListModel
    {
        public List<CommentLisModel> Comments { get; set; }
    }
    public class CommentLisModel
    {
        public int CommentId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string comment { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
