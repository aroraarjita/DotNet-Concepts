using MVCAppwithEF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLibrary;
using Employee = BusinessLibrary.Employee;



namespace MVCAppwithEF.Controllers
{
    public class EmployeeController : Controller
    {

        public ActionResult Index()
        
        {
            //EmployeeContext employeeContext = new EmployeeContext();
            //List<Employee> employees = employeeContext.Employees.Where(
            //    emp => emp.DepartmentId == departmentId).ToList();

            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            List<Employee> employees = employeeBusinessLayer.Employees.ToList();

            return View(employees);

        }



        // GET: Employee
        public ActionResult Details(int id)
        {
            //Employee employee = new Employee
            //{
            //    EmployeeId = 101,
            //    Name = "John",
            //    Gender = "Male"

            //};

            Database.SetInitializer<MVCAppwithEF.Models.EmployeeContext>(null);

            EmployeeContext employeeContext = new EmployeeContext();
            MVCAppwithEF.Models.Employee employee = employeeContext.Employees.Single(emp => emp.EmployeeId == id);



            return View(employee);
        }
        
        [HttpGet]
        [ActionName("Create")]
        public ActionResult Create_Get()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Create(FormCollection formCollection)
        //{

        //    Employee employee = new Employee();
        //    employee.Name = formCollection["Name"];
        //    employee.Gender = formCollection["Gender"];
        //    employee.City = formCollection["City"];
        //    employee.DateOfBirth = Convert.ToDateTime(formCollection["DateOfBirth"]);

        //    EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
        //    employeeBusinessLayer.AddEmployee(employee);

        //    return RedirectToAction("Index");
        //}


        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_Post(Employee employee)
        {
            //Employee employee = new Employee();
            //TryUpdateModel(employee);
            
            if (ModelState.IsValid)
            {
                EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
                employeeBusinessLayer.AddEmployee(employee);

                return RedirectToAction("Index");

            }
            return View();
            
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            Employee employee = employeeBusinessLayer.Employees.Single(emp => emp.Id == id);

            return View(employee);
        }


        [HttpPost]
        [ActionName("Edit")]
        public ActionResult Edit_Post([Bind(Exclude = "Name")]Employee employee)
        {

                EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
                employee.Name = employeeBusinessLayer.Employees.Single(x => x.Id == employee.Id).Name;
                //UpdateModel(employee, new string[] { "Id", "Gender", "City", "DateOfBirth" });
                //UpdateModel(employee, null, null, new string[] { "Name" });

                if (ModelState.IsValid)
                {
                    employeeBusinessLayer.SaveEmployee(employee);

                    return RedirectToAction("Index");
                }

                return View(employee);  

        }



        [HttpPost]
        public ActionResult Delete(int Id)
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            employeeBusinessLayer.DeleteEmployee(Id);

            return RedirectToAction("Index");
        }

    }
}