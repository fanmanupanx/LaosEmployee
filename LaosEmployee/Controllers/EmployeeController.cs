using LaosEmployee.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Diagnostics;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;

namespace LaosEmployee.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: EmployeeController
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

            Temploy1 temploy2 = new Temploy1
            {
                Id = "EMP002",
                Fname = "AA",
                Lname = "BB",
                Position = "Sr.Software Engineer",
                DateOfBirth = new DateTime(1990, 1, 1),
                DateOfJoining = new DateTime(2020, 5, 20),
                DateOfResign = new DateTime(2023, 12, 31),
                Salary = 20000.00m,
                Division = "IT",
                Department = "Development",
                Section = "Backend",
                Status = "Inactive"
            };

            Temploy1 temploy3 = new Temploy1
            {
                Id = "EMP003",
                Fname = "XX",
                Lname = "YY",
                Position = "System Engineer",
                DateOfBirth = new DateTime(1990, 1, 1),
                DateOfJoining = new DateTime(2020, 5, 20),
                DateOfResign = new DateTime(2023, 12, 31),
                Salary = 40000.00m,
                Division = "IT",
                Department = "Development",
                Section = "Backend",
                Status = "Active"
            };

            List<Temploy1> ls = new List<Temploy1>();
            ls.Add(temploy1);
            ls.Add(temploy2);
            ls.Add(temploy3);

            return View(ls);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
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

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeeController/Edit/5
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

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeController/Delete/5
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
