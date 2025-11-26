
namespace TemperatureConverterWAttributes
{
    public class ConverterInfoAttribute : Attribute
    {
        public string Description { get; }
        public ConverterInfoAttribute(string description)
        {
            Description = description;
        }
    }
}