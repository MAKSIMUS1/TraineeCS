using System.Globalization;
using System.Text;

namespace TextProcessing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var productsPath = "check.txt";

            if(!File.Exists(productsPath))
            {
                Console.WriteLine("Чек не найден");
                return;
            }

            var lines = File.ReadAllLines(productsPath);

            Console.WriteLine("Локаль пользователя:");
            CheckPrinter.ProcessLines(lines, CultureInfo.CurrentCulture);

            Console.WriteLine("\nЛокаль en-US:");
            CheckPrinter.ProcessLines(lines, new CultureInfo("en-US"));
        }
    }
}