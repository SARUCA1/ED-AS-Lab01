using Lab01_AS.Data;
using Lab01_AS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab01_AS.Controllers
{
    public class PersonController : Controller
    {
       
        // GET: PersonController
        public ActionResult Index()
        {
            return View(DataManagement.Instance.personlist);
        }

        // GET: PersonController/Details/5
        public ActionResult Details(int id)
        {
            var model = DataManagement.Instance.personlist.Find(Person => Person.Id == id);
            return View();
        }

        // GET: PersonController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                PersonModel.Save(new PersonModel
                {
                    Id = int.Parse(collection["Id"]),
                    Name = collection["Name"],
                    LastName = collection["Last Name"],
                    PhoneNumber = int.Parse(collection["Phone Number"]),
                    Description = collection["Description"],
                });
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonController/Edit/5
        public ActionResult Edit(int id)
        {
            var model = DataManagement.Instance.personlist.Find(person => person.ID == id);
            return View(model);
        }

        // POST: PersonController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonController/Delete/5
        public ActionResult Delete(int id)
        {
            var model = DataManagement.Instance.personlist.Find(person => person.ID == id);
            return View();
        }

        // POST: PersonController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
