using Polymorphism.NVI;
using System;
using System.Text;

namespace Polymorphism
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Worker programmer = new Programmer();
            Worker cook = new Cook();

            Console.WriteLine("--- Рабочий день программиста ---");
            programmer.WorkDay();

            Console.WriteLine("--- Рабочий день повара ---");
            cook.WorkDay();


            ForestCreature wolf = new Wolf();
            ForestCreature owl = new Owl();

            wolf.Act();
            owl.Act();
        }
    }
}