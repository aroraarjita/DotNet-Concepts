using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InnerExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter first number");
                    int FN = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter second number");
                    int SN = Convert.ToInt32(Console.ReadLine());

                    int Result = FN / SN;

                    Console.WriteLine("Result is {0}", Result);
                }

                catch (Exception ex)
                {
                    string filePath = (@"C:\Sample Files\Log.txt");
                    if (File.Exists(filePath))
                    {
                        StreamWriter streamWriter = new StreamWriter(filePath);
                        streamWriter.WriteLine(ex.GetType().Name);
                        streamWriter.Close();
                        Console.WriteLine("There is a problem, Please try again");

                    }
                    else
                    {
                        throw new FileNotFoundException(filePath + "is not present");


                    }

                }

            }
            catch(Exception exception)
            {
                Console.WriteLine("Current Exception:{0}", exception.GetType().Name);

                if(exception.InnerException != null)
                {
                    Console.WriteLine("Inner Exception:{0}", exception.InnerException.GetType().Name);
                }
                
                Console.ReadLine();
            }



        }
    }
}
