using Converter.Models;
using System.Collections.Generic;
using System.Linq;

namespace Converter.Data
{
    public interface IData
    {
        public const string NepalIndiaCustomaryLength = "(चाणक्य अर्थशास्त्र) नेपाल र भारतको परम्परागत लम्बाइ मापनको एकाइ";
        public const string NepalIndiaCustomaryArea = "(चाणक्य अर्थशास्त्र) नेपाल र भारतको परम्परागत क्षेत्रफल् मापनको एकाइ";
        public const string NepalCustomaryArea = "नेपालको परम्परागत क्षेत्रफल् मापनको एकाइ";
        public const string ImperialAndUSCustomaryLength = "British imperial and US customary systems of length measurement";
        public const string ImperialAndUSCustomaryArea = "British imperial and US customary systems of area measurement";
        public const string SIUnit = "Internation System of Units (SI)";

        public string CurrentNamedInstance { get; }

        public abstract Dictionary<string, (string NepaliUnicode, string ShortForm, string Details, double RatioToBase)> AvailableUnits { get; }

        public (string, string, string, double) GetUnitDescription(string name)
        {
            var contains = AvailableUnits.TryGetValue(name, value: out (string, string, string, double) unitData);
            if (contains)
                return unitData;
            return default;
        }

        public DropdownOption[] FetchDropdownUnitOptions() =>
            AvailableUnits.Select(option => new DropdownOption { Label = option.Value.NepaliUnicode, Value = option.Key }).ToArray();
    }
}
