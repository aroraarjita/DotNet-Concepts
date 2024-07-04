using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> listEmployees = new List<Employee>()
            {
                new Employee{ Id= 101, Name = "Mark"},
                new Employee{ Id = 102, Name = "John"},
                new Employee {Id =103, Name = "Mary"},
            };

            //Employee employee = listEmployees.Find(delegate(Employee emp){
            //    return emp.Id == 102;
            //});

            Func<Employee, string> selector = emp => "Name = " + emp.Name;

            IEnumerable<string> names = listEmployees.Select(selector);
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

            Func<int, int, string> funcDelegate = (firstNumber, secondNumber) => "Sum ="
              + (firstNumber + secondNumber).ToString();

            Console.ReadLine();

        }


        public static bool FindEmployee(Employee emp)
        {
            return emp.Id == 102;
        }

    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
