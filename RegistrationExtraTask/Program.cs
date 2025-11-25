using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace RegistrationExtraTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string login;
            while(true)
            {
                Console.Write("Логин: ");
                login = Console.ReadLine();

                if(Regex.IsMatch(login, @"^[A-Za-z]+$"))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Только латинские символы");
                }
            }

            string password;
            while (true)
            {
                Console.Write("Пароль: ");
                password = Console.ReadLine();

                if (Regex.IsMatch(login, @"^[0-9A-Za-z]+$"))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Только цифры и символы");
                }
            }
        }
    }
}