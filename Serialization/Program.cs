using System.Reflection;
using System.Text;
using System.Xml.Serialization;

namespace Serialization
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            ProductXmlSerializer.CreateProduct("product.xml");
            ProductXmlSerializer.ReadProduct("product.xml");
        }
    }
}