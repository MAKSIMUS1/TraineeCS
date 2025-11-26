using System.Reflection;
using System.Text;

namespace TemperatureConverter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string temperatureConverterDllName = "TemperatureConverterLib.dll";
            string dllPath = Path.Combine(AppContext.BaseDirectory, temperatureConverterDllName);
            Assembly asm = null;
            try
            {
                if (!File.Exists(dllPath))
                {
                    Console.WriteLine($"Ошибка: DLL не существует по пути: {dllPath}");
                    return;
                }
                asm = Assembly.LoadFrom(dllPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка загрузки DLL: {ex.Message}");
                return;
            }
            ReflectionInfo.GetReflectionInformation(asm);

            Type converterType = asm.GetType("TemperatureConverterLib.TemperatureConverter");
            if(converterType == null)
            {
                Console.WriteLine("Класс не найден");
                return;
            }

            MethodInfo celsiusToFahrenheit = converterType.GetMethod("CelsiusToFahrenheit");

            double celsiusTemperature = 25;
            object result = celsiusToFahrenheit.Invoke(null, new object[] { celsiusTemperature });

            Console.WriteLine($"{celsiusTemperature}C = {result}F");
        }
    }
}