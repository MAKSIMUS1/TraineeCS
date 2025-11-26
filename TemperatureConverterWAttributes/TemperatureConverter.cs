namespace TemperatureConverterWAttributes
{
    public static class TemperatureConverter
    {
        [ConverterInfo("Converts Celsius to Fahrenheit")]
        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        [ConverterInfo("Converts Fahrenheit to Celsius")]
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        [ConverterInfo("Converts Celsius to Kelvin")]
        public static double CelsiusToKelvin(double celsius)
        {
            return celsius + 273.15;
        }

        [ConverterInfo("Converts Kelvin to Celsius")]
        public static double KelvinToCelsius(double kelvin)
        {
            return kelvin - 273.15;
        }
    }

}