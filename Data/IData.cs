using Converter.Models;
using System.Collections.Generic;
using System.Linq;

namespace Converter.Data
{
    public interface IData
    {
        public abstract Dictionary<string, (string NepaliUnicode, double RatioToBase)> AvailableUnits { get; }

        public (string, double) GetAreaUnit(string name)
        {
            var contains = AvailableUnits.TryGetValue(name, value: out (string, double) unitData);
            if (contains)
                return unitData;
            return default;
        }

        public DropdownOption[] FetchDropdownUnitOptions() =>
            AvailableUnits.Select(option => new DropdownOption { Label = option.Value.NepaliUnicode, Value = option.Key }).ToArray();
    }
}
