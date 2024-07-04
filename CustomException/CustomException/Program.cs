using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CustomException
{


    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new UserAlreadyLoggedInException("User is logged in - no duplicate session allowed");
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
                Console.ReadLine();
            }
        }
        
    }

    [Serializable]
    public class UserAlreadyLoggedInException: Exception
    {
        public UserAlreadyLoggedInException()
        {

        }

        public UserAlreadyLoggedInException(string message): 
            base(message)
        {

        }

        public UserAlreadyLoggedInException(string message, Exception innerException):
            base(message, innerException)
        {

        }

        public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext streamingContext)
            :base(info, streamingContext)
        {

        }




    }
}
