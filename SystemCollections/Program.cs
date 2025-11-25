using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace SystemCollections
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Task 1
            var accounts = new Dictionary<int, int>();
            accounts.Add(1, 2);
            accounts.Add(2, 4);
            accounts.Add(3, 8);
            foreach (var a in accounts)
            {
                Console.WriteLine($"Счёт:{a.Key}, Сумма: {a.Value}");
            }

            var companies = new List<Company>();
            companies.Add(new Company(11, 500));
            companies.Add(new Company(12, 900));
            companies.Add(new Company(13, 1350));
            foreach (var comp in companies)
            {
                Console.WriteLine($"Счёт: {comp.Account}, Сумма: {comp.Balance}");
            }

            var companiesTuple = new List<Tuple<int, int>>();
            companiesTuple.Add(Tuple.Create(111, 650));
            companiesTuple.Add(Tuple.Create(112, 950));
            companiesTuple.Add(Tuple.Create(113, 1550));
            foreach (var compT in companiesTuple)
            {
                Console.WriteLine($"Счёт: {compT.Item1}, Сумма: {compT.Item2}");
            }

            // Task 2
            var dict = new OrderedDictionaryWrap<string, int>();
            dict.Add("one", 1);
            dict.Add("two", 2);

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }



            // Task extra
            var sortedList = new SortedList<string, int>();
            sortedList.Add("Banan", 3);
            sortedList.Add("Watermelon", 1);
            sortedList.Add("Apple", 9);
            sortedList.Add("Cherry", 5);
            sortedList.Add("Pear", 8);

            foreach(var f in sortedList)
            {
                Console.WriteLine($"{f.Key} - {f.Value}");
            }

            for(int i = sortedList.Count - 1; i >= 0; i--)
            {
                Console.WriteLine($"{sortedList.GetKeyAtIndex(i)} - {sortedList.GetValueAtIndex(i)}");
            }

        }
    }
}