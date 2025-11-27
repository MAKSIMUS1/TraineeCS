using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    public static class ProductXmlSerializer
    {
        public static void CreateProduct(string filename)
        {
            Product product = new Product { Name = "Nilk", Description = "White", Price = 12 };

            XmlSerializer serializer = new XmlSerializer(typeof(Product));

            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                serializer.Serialize(fs, product);
            }

            Console.WriteLine($"Объект сериализован в {filename}");

        }

        public static void ReadProduct(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Product));

            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                Product deserializedProduct = (Product)serializer.Deserialize(fs);

                Console.WriteLine("Данные объекта:");
                Console.WriteLine($"Имя: {deserializedProduct.Name}");
                Console.WriteLine($"Описание: {deserializedProduct.Description}");
                Console.WriteLine($"Цена: {deserializedProduct.Price}");
            }

        }
    }
}
