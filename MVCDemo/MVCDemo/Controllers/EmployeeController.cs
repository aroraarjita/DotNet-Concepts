using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeContext db = new EmployeeContext();

        // GET: Employee
        public ActionResult Index()
        {
            List<SelectListItem> ls = new List<SelectListItem>();
            foreach(var item in db.tblDepartments)
            {
                ls.Add(new SelectListItem() { Text = item.Name, Value = item.Id.ToString() });
            }


            ViewBag.Departments = new SelectList(ls, "Id", "Name");
            return View(db.tblEmployees.ToList());
        }


        public ActionResult EmployeesByDepartment()
        {
            List<SelectListItem> ls = new List<SelectListItem>();
            foreach (var item in db.tblDepartments)
            {
                ls.Add(new SelectListItem() { Text = item.Name, Value = item.Id.ToString() });
            }


            ViewBag.Departments = new SelectList(ls, "Id", "Name");
            return View(db.tblEmployees.GroupBy(x =>x.DepartmentId).Select(y =>  new DepartmentTotals
            {
                Name = y.Key.ToString(),
                Total =  y.Count()   

            }).ToList().OrderByDescending(y =>y.Total));
        }





        // GET: Employee/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblEmployee tblEmployee = db.tblEmployees.Find(id);
            if (tblEmployee == null)
            {
                return HttpNotFound();
            }
            return View(tblEmployee);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            List<SelectListItem> ls = new List<SelectListItem>();
            foreach (var item in db.tblDepartments)
            {
                ls.Add(new SelectListItem() { Text = item.Name, Value = item.Id.ToString() });
            }


            ViewBag.Departments = ls;
            return View();
        }

        // POST: Employee/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmployeeId,Name,Gender,City,DateOfBirth,DepartmentId")] tblEmployee tblEmployee)
        {
            if (string.IsNullOrEmpty(tblEmployee.Name))
            {
                ModelState.AddModelError("Name", "The Name field is required");
            }

            if (ModelState.IsValid)
            {
                db.tblEmployees.Add(tblEmployee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            List<SelectListItem> ls = new List<SelectListItem>();
            foreach (var item in db.tblDepartments)
            {
                ls.Add(new SelectListItem() { Text = item.Name, Value = item.Id.ToString() });
            }


            ViewBag.Departments = ls;
            return View(tblEmployee);
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int? id)
        {
            List<SelectListItem> ls = new List<SelectListItem>();
            foreach (var item in db.tblDepartments)
            {
                ls.Add(new SelectListItem() { Text = item.Name, Value = item.Id.ToString() });
            }


            ViewBag.Departments = ls;

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblEmployee tblEmployee = db.tblEmployees.Find(id);
            if (tblEmployee == null)
            {
                return HttpNotFound();
            }
            return View(tblEmployee);
        }

        // POST: Employee/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Exclude = "Name")] tblEmployee tblEmployee)
        {
            tblEmployee employeeFromDb = db.tblEmployees.Single(x => x.EmployeeId == tblEmployee.EmployeeId);
            employeeFromDb.Gender = tblEmployee.Gender;
            employeeFromDb.City = tblEmployee.City;
            employeeFromDb.DepartmentId = tblEmployee.DepartmentId;
            tblEmployee.Name = employeeFromDb.Name;

            List<SelectListItem> ls = new List<SelectListItem>();
            foreach (var item in db.tblDepartments)
            {
                ls.Add(new SelectListItem() { Text = item.Name, Value = item.Id.ToString() });
            }


            ViewBag.Departments = ls;

            if (ModelState.IsValid)
            {
               
                db.Entry(employeeFromDb).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblEmployee);
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblEmployee tblEmployee = db.tblEmployees.Find(id);
            if (tblEmployee == null)
            {
                return HttpNotFound();
            }
            return View(tblEmployee);
        }

        // POST: Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblEmployee tblEmployee = db.tblEmployees.Find(id);
            db.tblEmployees.Remove(tblEmployee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
