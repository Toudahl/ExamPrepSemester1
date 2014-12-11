using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace XMLAndPersistence
{
    class Program
    {
        private static PersonModel Bob;
        private static PersonModel NewBob;

        private static PersonModel Pete;
        private static PersonModel NewPete;

        static void Main(string[] args)
        {
            #region Reading and writing to and from an xml document
            XDocument xDoc = XDocument.Load("Bars.xml");

            Console.WriteLine("Print the original XML document");
            Console.WriteLine(xDoc);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Print the names of the bars");
            IEnumerable<XElement> elementsInXDoc = xDoc.Elements();

            foreach (XElement element in elementsInXDoc.Descendants("bar"))
            {
                Console.WriteLine(element.Attribute("name").Value);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Print the newly created XElement");
            XElement newBar = new XElement("bar");
            newBar.Add(new XAttribute("name", "a New bar"));
            newBar.Add(new XElement("address"));
            newBar.Element("address").Add(new XAttribute("street", "some street"));
            newBar.Element("address").Add(new XAttribute("number", "2"));
            newBar.Element("address").Add(new XAttribute("zipcode", "4000"));
            newBar.Element("address").Add(new XAttribute("city", "some city"));
            Console.WriteLine(newBar);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Add the XElement to the original XML document, and print it.");
            xDoc.Root.LastNode.AddAfterSelf(newBar);
            Console.WriteLine(xDoc);

            Console.WriteLine("Saving the modified XML document to 'NewBar.xml'");
            xDoc.Save("NewBar.xml");
            #endregion

            #region Serializing and Deserialize an object to/from Binary and XML format.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Bob = new PersonModel { Age = 10, Name = "Bob", Gender = "Male" };
            Console.WriteLine(Bob);
            SerializeToBinary(Bob);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            NewBob = DeserializeFromBinary();

            Console.WriteLine(NewBob);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Pete = new PersonModel { Age = 20, Name = "Pete", Gender = "Male" };
            Console.WriteLine(Pete);

            SerializeToXML(Pete);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            NewPete = DeserializeFromXML();
            Console.WriteLine(NewPete);
            #endregion
        }

        private static void SerializeToBinary(PersonModel saveThis)
        {
            using (Stream output = File.Create("Bob.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(output, saveThis);
            }
        }

        private static PersonModel DeserializeFromBinary()
        {
            using (Stream input = File.OpenRead("Bob.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return formatter.Deserialize(input) as PersonModel;
            }
        }
        private static void SerializeToXML(PersonModel saveThis)
        {
            using (Stream output = File.Create("Pete.xml"))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(PersonModel));
                formatter.Serialize(output, saveThis);
            }
        }

        private static PersonModel DeserializeFromXML()
        {
            using (Stream input = File.OpenRead("Pete.xml"))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(PersonModel));
                return formatter.Deserialize(input) as PersonModel;
            }
        }

    }
}
