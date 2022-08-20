using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u20691302_HW04.Data;
using u20691302_HW04.Models;

namespace u20691302_HW04.Controllers
{
    public class HomeController : Controller
    {
        


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        { 
            return View();
        }

        public ActionResult Animals()
        {
            List<MarineAnimals> marineAnimals = new List<MarineAnimals>();

            wildlifeDAO wildlifeDAO = new wildlifeDAO();

            marineAnimals = wildlifeDAO.FetchAll();

            return View("Animals", marineAnimals);
        }
    }
}