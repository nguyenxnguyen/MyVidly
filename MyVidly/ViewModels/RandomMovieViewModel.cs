using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyVidly.Models;

namespace MyVidly.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
    }
}