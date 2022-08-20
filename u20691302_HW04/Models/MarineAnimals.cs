﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20691302_HW04.Models
{
    public class MarineAnimals: Wildlife
    {
        private string mHabitat;

        public string Habitat { get => mHabitat; set => mHabitat = value; }

        public MarineAnimals()
        {
            
        }

        public MarineAnimals(string habitat, int id, string scientificName, int population, string status):base(id, scientificName, population, status)
        {
            Habitat = habitat; 
        }

        

        public override string getStatus()
        {
            string status = "";
            if (Population > 2000)
            {
                status = "Least concern / Near threatened";
            }
            else if (Population < 10000)
            {
                status = "Vulnerable";
            }
            else if (Population < 2500)
            {
                status = "Endangered";
            }
            else if (Population < 250)
            {
                status = "Critically endangered";
            }
            else if (Population == 0)
            {
                status = "Extinct in the wild";
            }
            return status;
        }
    }
}