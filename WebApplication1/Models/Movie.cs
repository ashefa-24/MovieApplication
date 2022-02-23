using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Movie
    {
        public int id { get; set; }
        public string Movie_title { get; set; }
        public string Director { get; set; }
        public string ReleaseDate { get; set; }
        public double Movie_Rating { get; set; }
        
    }
}