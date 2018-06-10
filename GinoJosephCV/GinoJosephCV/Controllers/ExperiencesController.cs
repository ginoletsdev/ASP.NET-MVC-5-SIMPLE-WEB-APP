using GinoJosephCV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GinoJosephCV.Controllers
{
    public class ExperiencesController : Controller
    {
        // GET: Experiences
        public ActionResult Index()
        {
            return View();
        }

        // GET: Experiences
        public ActionResult ListExperiences()
        {
            List<ExperienceModel> experiences = new List<ExperienceModel>();
            experiences.Add(new ExperienceModel { employer = "Employer1", jobTitle = "Job Ttle1", summary = "Summary1", roles = { new ExperienceRole { roleDescription = "Description 1" }, new ExperienceRole { roleDescription = "Description 1" } } });
            experiences.Add(new ExperienceModel { employer = "Employer2", jobTitle = "Job Ttle2", summary = "Summary2", roles = { new ExperienceRole { roleDescription = "Description 1" }, new ExperienceRole { roleDescription = "Description 2" } } });


            return View();
        }
    }
}