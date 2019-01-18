using MVCDemo2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo2.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
      
            return View();
        }

        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();
            people.Add(new PersonModel { FirstName = "Aisha", LastName = "Toulegenova", Age = 22 });
            people.Add(new PersonModel { FirstName = "Tim", LastName = "Corey", Age = 38 });
            people.Add(new PersonModel { FirstName = "Jessica", LastName = "Smith", Age = 30 });

            return View(people);

        }
    }
}