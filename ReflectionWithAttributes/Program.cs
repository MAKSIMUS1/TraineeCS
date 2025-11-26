using System.Reflection;
using System.Text;

namespace ReflectionWithAttributes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string temperatureConverterDllName = @"F:\Intermech_Trainee\TraineeCS\TemperatureConverterWAttributes\bin\Debug\net9.0\TemperatureConverterWAttributes.dll";

            Assembly asm = null;
            try
            {
                if (!File.Exists(temperatureConverterDllName))
                {
                    Console.WriteLine($"Ошибка: DLL не существует по пути: {temperatureConverterDllName}");
                    return;
                }
                asm = Assembly.LoadFrom(temperatureConverterDllName);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка загрузки DLL: {ex.Message}");
                return;
            }

            ReflectionWAttributes.GetReflectionInformation(asm);
        }
    }
}