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


        public const char Nepali = 'n';
        public const char SI = 's';
        public const char Imperial = 'i';

        public string CurrentNamedInstance { get; }

        public abstract Dictionary<string, (string NepaliUnicode, string ShortForm, char UnitFilterType, string Details, double RatioToBase)> GetAvailableUnits();

        public (string, string, char, string, double) GetUnitDescription(string name)
        {
            var contains = GetAvailableUnits().TryGetValue(name, value: out (string, string, char, string, double) unitData);
            if (contains)
                return unitData;
            return default;
        }

        public DropdownOption[] FetchDropdownUnitOptions() =>
            GetAvailableUnits().Select(option => new DropdownOption { Label = option.Value.NepaliUnicode, Value = option.Key, Type=option.Value.UnitFilterType }).ToArray();
    }
}
