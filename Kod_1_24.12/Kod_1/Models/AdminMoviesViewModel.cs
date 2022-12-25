using Kod_1.Entity;
using Kod_1.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kod_1.Models
{
    public class AdminMoviesViewModel
    {
        public List<AdminMovieViewModel> Movies { get; set; }
    }
    public class AdminMovieViewModel
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }

        public List<Genre> Genres { get; set; }
    }

    public class AdminCreateMovieModel
    {
        [Display(Name ="Film Adı")]
        [Required(ErrorMessage ="Film Adı Girmelisiniz.")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="Film Adı İçin 3-50 Karakter Girmelisiniz. ")]
        public string Title { get; set; }
        [Display(Name = "Film Açıklama")]
        [Required(ErrorMessage = "Film Açıklama Girmelisiniz.")]
        [StringLength(3000, MinimumLength = 10, ErrorMessage = "Film Açıklama İçin 10-3000 Karakter Girmelisiniz. ")]
        public string Description { get; set; }
        [Required(ErrorMessage = "En az bir tür seçmelisiniz.")]
        public bool IsClassic { get; set; }
        public int[] GenreIds { get; set; }

        [ClassicMovie(1950)]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; } = DateTime.Now;
    }
    public class AdminEditMovieViewModel
    {
        public int MovieId { get; set; }
        [Display(Name = "Film Adı")]
        [Required(ErrorMessage = "Film Adı Girmelisiniz.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Film Adı İçin 3-50 Karakter Girmelisiniz. ")]
        public string Title { get; set; }
        [Display(Name = "Film Açıklama")]
        [Required(ErrorMessage = "Film Açıklama Girmelisiniz.")]
        [StringLength(3000, MinimumLength = 10, ErrorMessage = "Film Açıklama İçin 10-3000 Karakter Girmelisiniz. ")]
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "En az bir tür seçmelisiniz.")]
        public int[] GenreIds { get; set; }

    }
}
