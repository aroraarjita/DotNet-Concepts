using System;

namespace XmlSerializationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generic Serialization/Deserialization");
            Console.WriteLine("--Serialized Employee Data--");
            Console.WriteLine("----------------------------------------------------");

            SerializeDeserialize<Employee> serializeEmployee;
            Employee employee = new Employee { ID = 1001, Name = "Praveen      Raveendran", 
                Profession = "IT Services" };

            serializeEmployee = new SerializeDeserialize<Employee>();

            string serializedEmployee = serializeEmployee.SerializeData(employee);
            Console.WriteLine("Serialized Employee Data");
            Console.WriteLine(serializedEmployee);
            Console.WriteLine("----------------------------------------------------");

            //Address Serialization/Deserialization
            SerializeDeserialize<Address> serializeAddress;
            Address address = new Address { HouseNo = 8911, 
                StreetName = "TechnoPark", City = "Trivandrum", Country = "India" };
            serializeAddress = new SerializeDeserialize<Address>();
            string serializedAddress = serializeAddress.SerializeData(address);
            Console.WriteLine("Serialized Address Data");
            Console.WriteLine(serializedAddress);
            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine("-----Deserailzed Address Data----------");
            Address deserailzedAddress = serializeAddress.DeserializedData(serializedAddress);


            Console.WriteLine("House No:{0}, Street:{1}, City:{2}, Country:{3}",
                deserailzedAddress.HouseNo, deserailzedAddress.StreetName,
                deserailzedAddress.City, deserailzedAddress.Country);
            Console.WriteLine("-----------------------------------");
            Console.ReadLine();

        }
    }
}
