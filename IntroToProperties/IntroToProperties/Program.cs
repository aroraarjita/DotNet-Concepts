using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToProperties
{
    public class Student
    {
         int _id;
         string _name;
         int _passMark = 35;

        public string Email
        {
            get;
            set;

        }

        public string City
        {
            get;
            set;
        }

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be null or empty");
                }
            }

            get
            {
                return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;
            }
        }

        public int Id
        {
            set
            {
                if(value <= 0)
                {
                    throw new Exception("Student Id cannot be negative");
                }

                this._id = value;
            }

            get
            {
                return this._id;
            }

        }

        public int PassMark
        {
            get
            {
                return this._passMark;
            }
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Id = 101;
            student.Name = "";

       


            Console.WriteLine("Student Id = {0}", student.Id);
            Console.WriteLine("Student Name = {0}", student.Name);
            Console.ReadLine();
        }
    }
}
