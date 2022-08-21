﻿using System;
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
        public ActionResult Create(MarineAnimals marineAnimals)
        {
            return View("Create", marineAnimals);
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



        //Create or update big cats
        public ActionResult CreateBigCats(BigCats bigCats)
        {
            return View("CreateBigCats", bigCats);
        }

        public ActionResult ProcessCreateBigCats(BigCats bigCats)
        {
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



        //Create or update Primates
        public ActionResult CreatePrimates(Primates primates)
        {
            return View("CreatePrimates", primates);
        }

        public ActionResult ProcessCreatePrimates(Primates primates)
        {
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

        //Delete marine primates
        public ActionResult DeletePrimates(int id)
        {
            wildlifeDAO wildlifeDAO = new wildlifeDAO();
            wildlifeDAO.DeletePrimates(id);

            List<Primates> primates = wildlifeDAO.FetchAllPrimates();

            return View("Primates", primates);
        }

    }
}