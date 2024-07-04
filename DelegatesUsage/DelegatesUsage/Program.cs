using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesUsage
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { ID = 101, Name = "Mary", Salary = 5000, Experience = 5 });
            employees.Add(new Employee() { ID = 101, Name = "Mike", Salary = 4000, Experience = 4 });
            employees.Add(new Employee() { ID = 101, Name = "John", Salary = 6000, Experience = 6 });
            employees.Add(new Employee() { ID = 101, Name = "Todd", Salary = 3000, Experience = 3 });

            //IsPromotable isPromotable = new IsPromotable(Promote);

            Employee.PromoteEmployee(employees,  emp => emp.Experience >= 5);
            Console.ReadLine();

        }

        //public static bool Promote(Employee employee)
        //{
        //    if(employee.Experience >= 5)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }


    public delegate bool IsPromotable(Employee employee);
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employeeList, IsPromotable isEligibleToPromote)
        {
            
            foreach(Employee employee in employeeList)
            {
                if(isEligibleToPromote(employee))
                {
                    Console.WriteLine(employee.Name + " promoted");
                }
            }

            Console.ReadLine();
        }



    }
}
