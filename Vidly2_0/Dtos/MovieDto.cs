using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly2_0.Models.CustomValidation;

namespace Vidly2_0.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime ReleasedDate { get; set; }

        public DateTime? DateAdded { get; set; }

        //[LimitValue]
        [Range(1, 20)]
        public int Stocks { get; set; }

        public byte GenreId { get; set; }

        public GenreDto GenreType { get; set; }
    }
}