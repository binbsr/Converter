namespace Converter.Models
{
    public class Unit
    {
        public string Name { get; }
        public string NepaliUnicode { get; set; }
        public string ShortForm { get; set; }
        public string Details { get; set; }
        public double Ratio { get; }

        public Unit(string name, string NpUnicode, string shortForm, string details, double ratio)
        {
            Name = name;
            NepaliUnicode = NpUnicode;
            ShortForm = shortForm;
            Details = details;
            Ratio = ratio;
        }

        public double Convert(double value, Unit toUnit)
        {
            return (value * Ratio) / toUnit.Ratio;
        }
    }
}
