using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TelephoneXML
{
    public static class XMLHelper
    {
        public static void CreateTelephoneBookXML(string fileName)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var doc = new XDocument(
                new XElement("MyContacts", 
                    new XElement("Contact", new XAttribute("TelephoneNumber", "+1-111-111-11-11"), "Bob"),
                    new XElement("Contact", new XAttribute("TelephoneNumber", "+2-222-222-22-22"), "Tom"),
                    new XElement("Contact", new XAttribute("TelephoneNumber", "+3-333-333-33-33"), "Ivan"))
                );

            doc.Save(fileName);
        }

        public static void ReadPhones(string fileName)
        {
            var doc = XDocument.Load(fileName);

            foreach (var contact in doc.Root.Elements("Contact"))
            {
                string phone = contact.Attribute("TelephoneNumber")?.Value;
                if(phone != null)
                    Console.WriteLine(phone);
            }
        }
    }
}
