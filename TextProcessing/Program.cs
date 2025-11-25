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

            Console.WriteLine("Локаль пользователя");
            CultureInfo userCultureInfo = CultureInfo.CurrentCulture;
            foreach(var line in lines)
            {
                string[] parts = line.Split(' ');
                string product = parts[0];
                DateTime date = DateTime.Parse(parts[1], userCultureInfo);
                string format = string.Format(userCultureInfo, "{0}: {1:D}", product, date);
                Console.WriteLine(format);
            }

            Console.WriteLine("Локаль en-US");
            CultureInfo enUS = new CultureInfo("en-US");
            foreach (var line in lines)
            {
                string[] parts = line.Split(' ');
                string product = parts[0];
                DateTime date = DateTime.ParseExact(parts[1], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                string format = string.Format(enUS, "{0}: {1:D}", product, date);
                Console.WriteLine(format);
            }
        }
    }
}