using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace u20691302_HW04.Models
{
    public abstract class Wildlife
    {
        public int ID { get; set; }
        [DisplayName("Scientific Name")]
        public string ScientificName { get; set; }
        public int Population { get; set; }
        public string Status { get; set; }
        [DisplayName("Upload Image")]
        public string ImgPath { get; set; }

        public HttpPostedFileBase Imgfile { get; set; }

        public Wildlife()
        {

        }

        public Wildlife(int id, string scientificName, int population, string status, string imgPath)
        {
            ID = id;
            ScientificName = scientificName;
            Population = population;
            Status = status;
            ImgPath = imgPath;
        }

        public abstract string getStatus();
    }   
}