using System;
using System.Text;

namespace UserCollections
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            CitizenCollection citizens = new CitizenCollection();

            Retiree r1 = new Retiree("P001");
            Retiree r2 = new Retiree("P002");
            Student s1 = new Student("S123");
            Worker w1 = new Worker("W555");
            Retiree r3 = new Retiree("P003");
            Student s2 = new Student("S123"); // duplicate

            Console.WriteLine("Добавляем граждан:");

            Console.WriteLine(citizens.Add(r1));
            Console.WriteLine(citizens.Add(r2));
            Console.WriteLine(citizens.Add(s1));
            Console.WriteLine(citizens.Add(w1));
            Console.WriteLine(citizens.Add(r3));

            Console.WriteLine(citizens.Add(s2));

            Console.WriteLine("\nВсе граждане в очереди:");
            foreach (Citizen c in citizens)
            {
                c.Info();
            }

            Citizen last = citizens.ReturnLast();
            if (last != null)
                Console.WriteLine($"\nПоследний гражданин: {last.Passport}");

            Console.WriteLine("\nУдаляем первого гражданина");
            citizens.Remove();

            Console.WriteLine("\nПосле удаления первого:");
            foreach (Citizen c in citizens)
            {
                c.Info();
            }

            Console.WriteLine("\nУдаляем гражданина с паспортом P002");
            citizens.Remove(r2);

            Console.WriteLine("\nПосле удаления P002:");
            foreach (Citizen c in citizens)
            {
                c.Info();
            }

            Console.WriteLine("\nОчищаем коллекцию");
            citizens.Clear();

            Console.WriteLine("Попытка удаления из пустой коллекции:");
            citizens.Remove();

            Console.WriteLine("\nПосле очистки, коллекция:");
            foreach (Citizen c in citizens)
            {
                c.Info();
            }

            // - - -
            Console.WriteLine(string.Join(" ", Helper.GetSquaresOdd(new int[] { 1, 2, 3, 4, 5, 6, 7 })));
        }
    }
}
