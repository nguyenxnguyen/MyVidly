using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyVidly.Models;

namespace MyVidly.ViewModels
{
    public class MovieViewModel
    {
        public IEnumerable<Movie> Movies { get; set; }
    }
}