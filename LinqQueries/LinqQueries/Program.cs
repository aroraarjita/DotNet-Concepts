using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQueries
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>
            {
              new Student() { StudentID = 1, StudentName = "John", Age = 18, StandardID = 1 },
              new Student() { StudentID = 2, StudentName = "Steve",  Age = 21, StandardID = 1 } ,
              new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID = 2 } ,
              new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID = 2 } ,
              new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
            };

            IList<Standard> standardList = new List<Standard>() {
            new Standard(){ StandardID = 1, StandardName="Standard 1"},
            new Standard(){ StandardID = 2, StandardName="Standard 2"},
            new Standard(){ StandardID = 3, StandardName="Standard 3"}
            };

            var studentNames = studentList.Where(s => s.Age > 18)
                               .Select(s => s)
                               .Where(st => st.StandardID > 0)
                               .Select(s => s);

            foreach(var student in studentNames)
            {
                Console.WriteLine(student.StudentName);
            }


            var teensStudentName = from s in studentList
                                   where s.Age > 12 && s.Age < 20
                                   select new { StudentName = s.StudentName };

            teensStudentName.ToList().ForEach(s => Console.WriteLine(s.StudentName));


            var studentsGroupByStandard = from s in studentList
                                          group s by s.StandardID into sg
                                          orderby sg.Key
                                          select new { sg.Key, sg };


            foreach(var group in studentsGroupByStandard)
            {
                Console.WriteLine("StandardID: {0}", group.Key);

                group.sg.ToList().ForEach(st => Console.WriteLine(st.StudentName));

            }

            var studentGroupByStandard = from s in studentList
                                         where s.StandardID > 0
                                         group s by s.StandardID into sg
                                         orderby sg.Key
                                         select new { sg.Key, sg };

            foreach(var group in studentGroupByStandard)
            {
                Console.WriteLine("Standard Id {0}", group.Key);

                group.sg.ToList().ForEach(st => Console.WriteLine(st.StudentName));

            }


            var studentsWithStandard = from stad in standardList
                                       join s in studentList
                                       on stad.StandardID equals s.StandardID
                                       into sg
                                       from std_grp in sg
                                       orderby stad.StandardName, std_grp.StudentName
                                       select new
                                       {
                                           StudentName = std_grp.StudentName,
                                           StandardName = stad.StandardName
                                       };

            foreach(var group in studentsWithStandard)
            {
                Console.WriteLine("{0} is in {1}", group.StudentName, group.StandardName);
            }


            var sortedStudents = from s in studentList
                                 orderby s.StandardID, s.Age
                                 select new
                                 {
                                     StudentName = s.StudentName,
                                     Age = s.Age,
                                     StandardID = s.StandardID
                                 };

            sortedStudents.ToList().ForEach(s => Console.WriteLine("Student Name: {0}, " +
                "Age: {1}, StandardId: {2}", s.StudentName, s.Age, s.StandardID));


            var studentWithStandard = from s in studentList
                                      join stad in standardList
                                      on s.StandardID equals stad.StandardID
                                      select new
                                      {
                                          StudentName = s.StudentName,
                                          StandardName = stad.StandardName
                                      };

            studentWithStandard.ToList().ForEach(s => Console.WriteLine("{0} " +
                "is in {1}", s.StudentName, s.StandardName));

            var nestedQueries = from s in studentList
                                where s.Age > 18 && s.StandardID ==
                                (from std in standardList
                                 where std.StandardName == "Standard 1"
                                 select std.StandardID).FirstOrDefault()
                                select s;

            nestedQueries.ToList().ForEach(s => Console.WriteLine(s.StudentName));

            Console.ReadLine();

        }
    }


    public class Student
    {
        public Student()
        {

        }
        public int StudentID { get; set; }

        public string StudentName { get; set; }

        public int Age { get; set; }

        public int StandardID { get; set; }
    }
    public class Standard
    {
        public Standard()
        {

        }
        public int StandardID { get; set; }
        public string StandardName { get; set; }
    }


}
