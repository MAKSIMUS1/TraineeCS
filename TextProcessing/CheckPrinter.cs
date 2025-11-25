using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProcessing
{
    public static class CheckPrinter
    {
        public static void ProcessLines(IEnumerable<string> lines, CultureInfo culture)
        {
            foreach (var line in lines)
            {
                string[] parts = line.Split(' ');
                string product = parts[0];

                DateTime date = DateTime.ParseExact(parts[1], "dd.MM.yyyy", CultureInfo.InvariantCulture);

                string formatted = string.Format(culture, "{0}: {1:D}", product, date);
                Console.WriteLine(formatted);
            }
        }
    }

}
