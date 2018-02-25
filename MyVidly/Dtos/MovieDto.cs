using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MyVidly.Models;

namespace MyVidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public GenreDto Genre { get; set; }

        [Required]
        public byte GenreId { get; set; }

        public DateTime ReleaseDate { get; set; }

        [Range(1, 20)]
        public byte Inventory { get; set; }
    }
}