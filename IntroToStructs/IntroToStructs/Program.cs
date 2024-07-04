﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToStructs
{
    public struct Customer
    {
        private int _id;
        private string _name;

        public int ID
        {
            get { return this._id; }
            set { this._id = value; }
        }
        public string Name  {
            get { return _name; }
            set { _name = value; } 
        }

        public Customer(int Id, string Name)
        {
            this._id = Id;
            this._name = Name;
        }

        public void PrintDetails()
        {
            Console.WriteLine("Id = {0} && Name = {1}", this._id, this._name);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer(100, "Mark");
            C1.PrintDetails();

            Customer C2 = new Customer();
            C2.ID = 101;
            C2.Name = "Jacob";
            C2.PrintDetails();

            Customer C3 = new Customer
            {
                ID = 102,
                Name = "Jacob"
            };
            C3.PrintDetails();
            Console.ReadLine();



        }
    }
}
