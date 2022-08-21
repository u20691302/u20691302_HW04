using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20691302_HW04.Models
{
    public class BigCats:Wildlife
    {
        private string mHabitat;

        public string Habitat { get => mHabitat; set => mHabitat = value; }

        public BigCats()
        {

        }

        public BigCats(string habitat, int id, string scientificName, int population, string status) : base(id, scientificName, population, status)
        {
            Habitat = habitat;
        }

        public override string getStatus()
        {
            string status = "";
            if (Population > 10000)
            {
                status = "Least concern / Near threatened";
            }
            if (Population < 10000)
            {
                status = "Vulnerable";
            }
            if (Population < 2500)
            {
                status = "Endangered";
            }
            if (Population < 250)
            {
                status = "Critically endangered";
            }
            if (Population == 0)
            {
                status = "Extinct in the wild";
            }
            return status;
        }
    }
}