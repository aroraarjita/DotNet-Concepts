using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace XmlSerializationExample
{
    class SerializeDeserialize<T>
    {
        StringBuilder sbData;
        StringWriter swWriter;
        XmlDocument xDoc;
        XmlNodeReader xNodeReader;
        XmlSerializer xmlSerializer;

        public SerializeDeserialize()
        {
            sbData = new StringBuilder();
        }

        public string SerializeData(T data)
        {
            XmlSerializer employeeSerializer = new XmlSerializer(typeof(T));
            swWriter = new StringWriter(sbData);
            employeeSerializer.Serialize(swWriter, data);
            return sbData.ToString();

        }

        public T DeserializedData(string dataXML)
        {
            xDoc = new XmlDocument();
            xDoc.LoadXml(dataXML);
            xNodeReader = new XmlNodeReader(xDoc.DocumentElement);
            xmlSerializer = new XmlSerializer(typeof(T));
            var empData = xmlSerializer.Deserialize(xNodeReader);
            T deserializedEmployee = (T)empData;
            return deserializedEmployee;


        }






    }
}
