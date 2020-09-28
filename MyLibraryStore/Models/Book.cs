using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibraryStore.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Book Name is required")]
        [Display(Name="Book Name")]
        public string BookName { get; set; }

        [Required(ErrorMessage ="Author Name is Required")]
        [Display(Name ="Author Name")]
        public string Author { get; set; }

        [Required(ErrorMessage ="ISBN number is required")]
        public string ISBN { get; set; }

        public Genre Genre { get; set; }

        //[Display(Name = "Genre")]
        //[Required]
        //public int GenreId { get; set; }

        [Display(Name ="Published Date")]
        [DataType(DataType.Date)]
        public DateTime PublishedDate { get; set; }
    }
}
