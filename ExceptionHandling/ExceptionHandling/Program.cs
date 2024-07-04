using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExceptionHandling
{

    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"C:\Sample Files\Data.txt");
                Console.WriteLine(streamReader.ReadToEnd());
                streamReader.Close();
                Console.ReadLine();
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(ex.StackTrace);
                Console.ReadLine();

                Console.WriteLine("Please check if the file {0} exists", ex.FileName);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            finally
            {
                if(streamReader != null)
                {
                    streamReader.Close();
                }               
                Console.WriteLine("Finally Block");
                Console.ReadLine();
            }
           

            
        }
    }
}
