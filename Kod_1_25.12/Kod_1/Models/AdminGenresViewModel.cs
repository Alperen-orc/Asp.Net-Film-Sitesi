using Kod_1.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kod_1.Models
{
    public class AdminGenresViewModel
    {
        [Required(ErrorMessage ="Tür bilgisi girmelisiniz.")]
        public string Name { get; set; }
        public List<AdminGenreViewModel> Genres { get; set; }
    }

    public class AdminGenreViewModel
    {
        public int GenreId { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
    }

    public class AdminGenreEditViewModel
    {
        public int GenreId { get; set; }
        [Required(ErrorMessage = "Tür bilgisi girmelisiniz.")]
        public string Name { get; set; }
        public List<AdminMovieViewModel> Movies { get; set; }
    }
}
