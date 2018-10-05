using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearningASP.NET_MVC_V0._0._2.Models;

namespace LearningASP.NET_MVC_V0._0._2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var albums = new List<Album> //Creating list of albums, generally we should insert here informations from database. 
            {
                new Album {Artist = "U2", AlbumName = "The Best of"},
                new Album {Artist = "Coldplay", AlbumName = "Mylo Xyloto"}
            };

            ViewBag.Albums = albums;
            return View();
        }

        //public string Index(string id)
        //{
        //    return "Witaj, " + id;
        //}

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page."; //For example this information will be read by About.cshtml(Views)

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}