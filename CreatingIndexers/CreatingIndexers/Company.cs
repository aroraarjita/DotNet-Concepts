using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;


namespace CreatingIndexers
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }

    public class Company
    {
        List<Employee> listEmployess;

        public Company()
        {
            listEmployess = new List<Employee>();
            listEmployess.Add(new Employee() { EmployeeId = 1, Name = "Mike", Gender = "Male" });
            listEmployess.Add(new Employee() { EmployeeId = 2, Name = "Pam", Gender = "Female" });
            listEmployess.Add(new Employee() { EmployeeId = 3, Name = "John", Gender = "Male" });
            listEmployess.Add(new Employee() { EmployeeId = 4, Name = "Maxine", Gender = "Female" });
            listEmployess.Add(new Employee() { EmployeeId = 5, Name = "Emiliy", Gender = "Female" });
            listEmployess.Add(new Employee() { EmployeeId = 6, Name = "Scott", Gender = "Male" });
            listEmployess.Add(new Employee() { EmployeeId = 7, Name = "Todd", Gender = "Male" });
            listEmployess.Add(new Employee() { EmployeeId = 8, Name = "Benn", Gender = "Male" });
        }


        public string this[int employeeId]
        {
            get
            {
                return listEmployess.FirstOrDefault(emp => emp.EmployeeId == employeeId).Name;
            }

            set
            {
                listEmployess.FirstOrDefault(emp => emp.EmployeeId == employeeId).Name = value;

            }
        }

        public string this[string Gender]
        {
            get
            {
                return listEmployess.Count(emp => emp.Gender == Gender).ToString();
            }

            set
            {
              foreach(Employee employee in listEmployess)
                {
                    if(employee.Gender == Gender)
                    {
                        employee.Gender = value;
                    }
                }

            }
        }


    }
}