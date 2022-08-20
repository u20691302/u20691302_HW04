using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20691302_HW04.Models
{
    public abstract class Wildlife
    {
        public int ID { get; set; }
        public string ScientificName { get; set; }
        public int Population { get; set; }
        public string Status { get; set; }

        public Wildlife()
        {

        }

        public Wildlife(int id, string scientificName, int population, string status)
        {
            ID = id;
            ScientificName = scientificName;
            Population = population;
            Status = status;
        }

        public abstract string getStatus();
    }   
}