using LaosEmployee.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LaosEmployee.Controllers
{
    public class Temploy1Controller : Controller
    {
        // GET: Temploy1Controller
        public ActionResult Index()
        {
            Temploy1 temploy1 = new Temploy1
            {
                Id = "EMP001",
                Fname = "John",
                Lname = "Doe",
                Position = "Software Engineer",
                DateOfBirth = new DateTime(1990, 1, 1),
                DateOfJoining = new DateTime(2020, 5, 20),
                DateOfResign = new DateTime(2023, 12, 31),
                Salary = 60000.00m,
                Division = "IT",
                Department = "Development",
                Section = "Backend",
                Status = "Active"
            };

            return View(temploy1);
        }

        // GET: Temploy1Controller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Temploy1Controller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Temploy1Controller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: Temploy1Controller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Temploy1Controller/Edit/5
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

        // GET: Temploy1Controller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Temploy1Controller/Delete/5
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
