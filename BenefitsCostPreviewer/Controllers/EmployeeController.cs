using System.Web.Mvc;
using BenefitsCostPreviewer.Models;
using Employee = BenefitsCostPreviewer.Models.Employee;

namespace BenefitsCostPreviewer.Controllers
{
    public class EmployeeController : Controller
    {
        readonly Employee _employee = new Employee();
        readonly Calculator _calculator = new Calculator();

        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        // GET: Employee/Details
        public ActionResult Details(Employee employee)
        {
            _calculator.CalculateBenefitsPreview(employee);
            return View(employee);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                _employee.Name = Request.Form["name"];

                _employee.Dependant1Name = Request.Form["d1Name"];
                _employee.Dependant2Name = Request.Form["d2Name"];
                _employee.Dependant3Name = Request.Form["d3Name"];
                _employee.Dependant4Name = Request.Form["d4Name"];

                return RedirectToAction("Details", _employee);
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
