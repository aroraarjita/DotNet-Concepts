using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirstApproach
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var ctx = new SchoolDBEntities1())
            {
                //var anonymousObjResult = from s in ctx.Students
                //                         where s.StudentID == 3
                //                         select new
                //                         {
                //                             Id = s.StudentID,
                //                             Name = s.StudentName
                //                         };
                //foreach(var obj in anonymousObjResult)
                //{
                //    Console.WriteLine(obj.Name);
                //}

                //Console.ReadLine();

                var nestedQuery = from s in ctx.Students
                                  from c in s.Courses
                                  where s.StandardId == 4
                                  select new { s.StudentName, c };

                var result = nestedQuery.ToList();

            }
        }
    }
}
