using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WUDIF.DAL;
using WUDIF.Models;

namespace WUDIF.Controllers
{
    //[RequireHttps]
    public class HomeController : Controller
    {
        private MainDBContext db = new MainDBContext();
        

        public ActionResult Index()
        {
            Models.ViewModels.MainPage MainModel = new Models.ViewModels.MainPage();

            var selection = db.Questions.Where(o => true);
            MainModel.RandomQuestion = new Models.Question();
            try
            {
                Models.Question RandomQuestion = selection
                .OrderBy(c => c.AddDate)
                .Skip(new Random().Next(selection.Count()))
                .First();

                MainModel.RandomQuestion = RandomQuestion;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return View(MainModel);
            }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}