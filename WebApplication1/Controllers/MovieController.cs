using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MovieController : Controller
    {
        List<Movie> MovieList = new List<Movie>
        {
            new Movie()
            {
                Movie_id =101,
                Movie_title = "The Originals",
                Director = "Julie",
                ReleaseDate = "02 / 22 / 2000",
                Movie_Rating = 8.9
            },
            new Movie()
            {
                Movie_id =102,
                Movie_title = "Money Heist",
                Director = "Alex Pina",
                ReleaseDate = "12 / 12 / 2021",
                Movie_Rating = 9.8
            },
            new Movie()
            {
                Movie_id =103,
                Movie_title = "Dark",
                Director = "Baran",
                ReleaseDate = "02 / 05 / 2019",
                Movie_Rating = 8.5
            },
            new Movie()
            {
                Movie_id =104,
                Movie_title = "Stranger Things",
                Director = "Shawn",
                ReleaseDate = "08 / 09 / 2017",
                Movie_Rating = 9
            },
            new Movie()
            {
                Movie_id =105,
                Movie_title = "Harry Potter",
                Director = "J.K. Rowling",
                ReleaseDate = "09 / 28 / 2007",
                Movie_Rating = 9
            }
        };

        //public ActionResult getDetails()
        //{
        //    //Movie m = new Movie()
        //    //{
        //    //    Movie_id =101,
        //    //    Movie_title = "The Originals",
        //    //    Director = "Klaus",
        //    //    ReleaseDate = "02 / 22 / 2000"
        //    //};

        //    //return View(m);
        //    //ViewData["Movies"] = MovieList;
        //    //ViewData["Header"] = "Movie Details";
        //    return View(MovieList);
        //}
        public ActionResult getDetails(List<Movie> MovieList1)
        {
            //ViewData["Movies"] = MovieList;
            //ViewData["Header"] = "Movie Details";
            if(MovieList1 == null)
            {
                MovieList1 = MovieList;
            }
            return View(MovieList1);
        }
        [HttpGet]
        public ActionResult ModifyMovie(int Movie_id)
        {
            Movie mv = null;
            var FindMovie = MovieList.Where(i => i.Movie_id == Movie_id).FirstOrDefault();
            if(FindMovie != null)
            {
                mv = FindMovie;
            }
            return View(mv);
        }
        [HttpPost]
        public ActionResult ModifyMovie(Movie mv)
        {
            //Movie edit_mv = null;
            var FindMovie = MovieList.Where(i => i.Movie_id == mv.Movie_id).FirstOrDefault();
            if(FindMovie != null)
            {
                FindMovie.Movie_title = mv.Movie_title;
                FindMovie.Director = mv.Director;
                FindMovie.ReleaseDate = mv.ReleaseDate;
                FindMovie.Movie_Rating = mv.Movie_Rating;
            }
            return View("getDetails", MovieList);
        }
        public ActionResult MovieDetils(Movie mv)
        {
            return View(mv);
        }
    }
}