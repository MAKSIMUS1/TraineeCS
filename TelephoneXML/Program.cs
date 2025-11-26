using System;
using System.Xml;

namespace TelephoneXML
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string fileName = "TelephoneBook.xml";

            XMLHelper.CreateTelephoneBookXML(fileName);

            Console.WriteLine("Телефонные номера:");
            XMLHelper.ReadPhones(fileName);
        }
    }
}