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

            List<ExperienceRole> Experience1Roles = new List<ExperienceRole>();
            Experience1Roles.Add(new ExperienceRole { roleDescription = "Description1" });
            Experience1Roles.Add(new ExperienceRole { roleDescription = "Description1Another" });

            List<ExperienceRole> Experience2Roles = new List<ExperienceRole>();
            Experience2Roles.Add(new ExperienceRole { roleDescription = "Description2" });
            Experience2Roles.Add(new ExperienceRole { roleDescription = "Description2Another" });

            ExperienceRole ExperienceRole1 = new ExperienceRole() { roleDescription = "Description1"};
            ExperienceRole ExperienceRole2 = new ExperienceRole() { roleDescription = "Description2" };
            experiences.Add(new ExperienceModel { employer = "Employer1", jobTitle = "Job Ttle1", summary = "Summary1", roles = Experience1Roles });
            experiences.Add(new ExperienceModel { employer = "Employer2", jobTitle = "Job Ttle2", summary = "Summary2", roles = Experience2Roles });


            return View(experiences);
        }
    }
}