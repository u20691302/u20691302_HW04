using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u20691302_HW04.Data;
using u20691302_HW04.Models;
using System.IO;

namespace u20691302_HW04.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }



        //Read database into tables
        public ActionResult Animals()
        {
            List<MarineAnimals> marineAnimals = new List<MarineAnimals>();

            wildlifeDAO wildlifeDAO = new wildlifeDAO();

            marineAnimals = wildlifeDAO.FetchAll();

            return View("Animals", marineAnimals);
        }

        public ActionResult BigCats()
        {
            List<BigCats> bigCats = new List<BigCats>();

            wildlifeDAO wildlifeDAO = new wildlifeDAO();

            bigCats = wildlifeDAO.FetchAllCats();

            return View("BigCats", bigCats);
        }

        public ActionResult Primates()
        {
            List<Primates> primates = new List<Primates>();

            wildlifeDAO wildlifeDAO = new wildlifeDAO();

            primates = wildlifeDAO.FetchAllPrimates();

            return View("Primates", primates);
        }



        //Get details
        public ActionResult Details(int id)
        {
            wildlifeDAO wildlifeDAO = new wildlifeDAO();
            MarineAnimals marineAnimals = wildlifeDAO.FetchOne(id);

            return View("Details", marineAnimals);
        }

        public ActionResult DetailsBigCats(int id)
        {
            wildlifeDAO wildlifeDAO = new wildlifeDAO();
            BigCats bigCats = wildlifeDAO.FetchOneBigCats(id);

            return View("DetailsBigCats", bigCats);
        }

        public ActionResult DetailsPrimates(int id)
        {
            wildlifeDAO wildlifeDAO = new wildlifeDAO();
            Primates primates = wildlifeDAO.FetchOnePrimates(id);

            return View("DetailsPrimates", primates);
        }


        
        //Create or update marine animals
        [HttpGet]
        public ActionResult Create(MarineAnimals marineAnimals)
        {
            return View("Create", marineAnimals);
        }

        [HttpPost]
        public ActionResult ProcessCreate(MarineAnimals marineAnimals)
        {
            string fileName = Path.GetFileNameWithoutExtension(marineAnimals.Imgfile.FileName);
            string extension = Path.GetExtension(marineAnimals.Imgfile.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            marineAnimals.ImgPath = "~/Resources/" + fileName;
            fileName = Path.Combine(Server.MapPath("~/Resources/"), fileName);
            marineAnimals.Imgfile.SaveAs(fileName);
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



        //Create or update big cats
        [HttpGet]
        public ActionResult CreateBigCats(BigCats bigCats)
        {
            return View("CreateBigCats", bigCats);
        }
        [HttpPost]
        public ActionResult ProcessCreateBigCats(BigCats bigCats)
        {
            string fileName = Path.GetFileNameWithoutExtension(bigCats.Imgfile.FileName);
            string extension = Path.GetExtension(bigCats.Imgfile.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            bigCats.ImgPath = "~/Resources/" + fileName;
            fileName = Path.Combine(Server.MapPath("~/Resources/"), fileName);
            bigCats.Imgfile.SaveAs(fileName);
            //save to the db
            wildlifeDAO wildlifeDAO = new wildlifeDAO();

            wildlifeDAO.CreateOrUpdateBigCats(bigCats);

            return View("DetailsBigCats", bigCats);
        }

        public ActionResult EditBigCats(int id)
        {
            wildlifeDAO wildlifeDAO = new wildlifeDAO();
            BigCats bigCats = wildlifeDAO.FetchOneBigCats(id);

            return View("CreateBigCats", bigCats);
        }



        //Create or update primates
        public ActionResult CreatePrimates(Primates primates)
        {
            return View("CreatePrimates", primates);
        }

        public ActionResult ProcessCreatePrimates(Primates primates)
        {
            string fileName = Path.GetFileNameWithoutExtension(primates.Imgfile.FileName);
            string extension = Path.GetExtension(primates.Imgfile.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            primates.ImgPath = "~/Resources/" + fileName;
            fileName = Path.Combine(Server.MapPath("~/Resources/"), fileName);
            primates.Imgfile.SaveAs(fileName);
            //save to the db
            wildlifeDAO wildlifeDAO = new wildlifeDAO();

            wildlifeDAO.CreateOrUpdatePrimates(primates);

            return View("DetailsPrimates", primates);
        }

        public ActionResult EditPrimates(int id)
        {
            wildlifeDAO wildlifeDAO = new wildlifeDAO();
            Primates primates = wildlifeDAO.FetchOnePrimates(id);

            return View("CreatePrimates", primates);
        }



        //Delete marine animals
        public ActionResult Delete(int id)
        {
            wildlifeDAO wildlifeDAO = new wildlifeDAO();
            wildlifeDAO.Delete(id);

            List<MarineAnimals> marineAnimals = wildlifeDAO.FetchAll();

            return View("Animals", marineAnimals);
        }

        //Delete bigcats
        public ActionResult DeleteBigCats(int id)
        {
            wildlifeDAO wildlifeDAO = new wildlifeDAO();
            wildlifeDAO.DeleteBigCats(id);

            List<BigCats> bigCats = wildlifeDAO.FetchAllCats();

            return View("BigCats", bigCats);
        }

        //Delete primates
        public ActionResult DeletePrimates(int id)
        {
            wildlifeDAO wildlifeDAO = new wildlifeDAO();
            wildlifeDAO.DeletePrimates(id);

            List<Primates> primates = wildlifeDAO.FetchAllPrimates();

            return View("Primates", primates);
        }



        //Search marine animals
        public ActionResult SearchMarineAnimals()
        {
            return View("SearchMarineAnimals");
        }

        public ActionResult SearchForMarineAnimals(string searchPhrase)
        {
            //get list of search results
            wildlifeDAO wildlifeDAO = new wildlifeDAO();

            List<MarineAnimals> searchResults = wildlifeDAO.SearchForMarineAnimals(searchPhrase);

            return View("Animals", searchResults);
        }

        //Search big cats
        public ActionResult SearchBigCats()
        {
            return View("SearchBigCats");
        }

        public ActionResult SearchForBigCats(string searchPhrase)
        {
            //get list of search results
            wildlifeDAO wildlifeDAO = new wildlifeDAO();

            List<BigCats> searchResults = wildlifeDAO.SearchForBigCats(searchPhrase);

            return View("BigCats", searchResults);
        }

        //Search primates
        public ActionResult SearchPrimates()
        {
            return View("SearchPrimates");
        }

        public ActionResult SearchForPrimates(string searchPhrase)
        {
            //get list of search results
            wildlifeDAO wildlifeDAO = new wildlifeDAO();

            List<Primates> searchResults = wildlifeDAO.SearchForPrimates(searchPhrase);

            return View("Primates", searchResults);
        }
    }
}