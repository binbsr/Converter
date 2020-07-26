using Converter.Models;
using System.Collections.Generic;
using System.Linq;

namespace Converter.Data
{
    public static class AreaData
    {
        // Taking squarefeet as base
        public static Dictionary<string, (string NepaliUnicode, double RatioToBase)> AvailableUnits => new Dictionary<string, (string, double)>
        {
            [AreaUnit.KhetMuri] = ("खेतमुरी", 136900),
            [AreaUnit.Ropani] = ("रोपनी", 5476),
            [AreaUnit.Bigha] = ("बिघा", 72900),
            [AreaUnit.Katha] = ("कठ्ठा", 3645),
            [AreaUnit.Dhur] = ("धुर", 182.25),
            [AreaUnit.Aana] = ("आना", 342.25),
            [AreaUnit.Paisa] = ("पैसा", 85.5625),
            [AreaUnit.Daam] = ("दाम", 21.390625),

            [AreaUnit.Acre] = ("एकड", 43560),
            [AreaUnit.Hectare] = ("हेक्टर", 107639.10417),
            [AreaUnit.SquareFeet] = ("वर्ग फिट ", 1),
            [AreaUnit.SquareMetre] = ("वर्ग मिटर", 10.76391),
            [AreaUnit.SquareKilometre] = ("वर्ग किलोमिटर", 10763910.417)
        };

        public static (string, double) GetAreaUnit(string name)
        {
            var contains = AvailableUnits.TryGetValue(name, value: out (string, double) unitData);
            if (contains)
                return unitData;
            return default;
        }

        public static DropdownOption[] FetchDropdownUnitOptions() =>
            AvailableUnits.Select(option => new DropdownOption { Label = option.Value.NepaliUnicode, Value = option.Key }).ToArray();
    }
}
