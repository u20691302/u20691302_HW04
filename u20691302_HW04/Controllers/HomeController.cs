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

        public ActionResult Animals()
        {
            List<MarineAnimals> marineAnimals = new List<MarineAnimals>();

            wildlifeDAO wildlifeDAO = new wildlifeDAO();

            marineAnimals = wildlifeDAO.FetchAll();

            return View("Animals", marineAnimals);
        }

        public ActionResult Details(int id)
        {
            wildlifeDAO wildlifeDAO = new wildlifeDAO();
            MarineAnimals marineAnimals = wildlifeDAO.FetchOne(id);

            return View("Details", marineAnimals);
        }

        public ActionResult Create()
        {
            return View("Create");
        }

        
        public ActionResult ProcessCreate(MarineAnimals marineAnimals)
        {
            //save to the db
            wildlifeDAO wildlifeDAO = new wildlifeDAO();

            wildlifeDAO.CreateOrUpdate(marineAnimals);

            return View("Details", marineAnimals);
            
        }

        public ActionResult Edit(int id)
        {
            wildlifeDAO wildlifeDAO = new wildlifeDAO();
            MarineAnimals marineAnimals = wildlifeDAO.FetchOne(id);

            return View("Create", marineAnimals);
        }


        public ActionResult Delete(int id)
        {
            wildlifeDAO wildlifeDAO = new wildlifeDAO();
            wildlifeDAO.Delete(id);

            List<MarineAnimals> marineAnimals = wildlifeDAO.FetchAll();


            return View("Animals", marineAnimals);
        }
    }
}