using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GinoJosephCV.Models
{
    public class ExperienceModel
    {
        public string employer { get; set; } = "";
        public string jobTitle { get; set; } = "";
        public string summary { get; set; } = "";
        public List<ExperienceRole> roles;


    }

    public class ExperienceRole
    {
        public string roleDescription { get; set; }
    }
}