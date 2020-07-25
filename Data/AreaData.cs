using Converter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Converter.Data
{
    public static class AreaData
    {
        // Taking m^2 as base
        public static Dictionary<string, (string NepaliUnicode, double RatioToBase)> AvailableUnits => new Dictionary<string, (string, double)>
        {
            [AreaUnit.KhetMuri] = ("खेतमुरी", 12718.0),
            [AreaUnit.Ropani] = ("रोपनी", 508.72),
            [AreaUnit.Bigha] = ("बिघा", 6772.63),
            [AreaUnit.Katha] = ("कठ्ठा", 338.63),
            [AreaUnit.Dhur] = ("धुर", 16.93),
            [AreaUnit.Aana] = ("आना",31.80),
            [AreaUnit.Paisa] = ("पैसा", 7.95),
            [AreaUnit.Daam] = ("दाम", 1.99),
            [AreaUnit.Acre] = ("एकड", 4046.856),
            [AreaUnit.Hectare] = ("हेक्टर", 10000),
            [AreaUnit.Squaremetre] = ("वर्ग मिटर", 1),
            [AreaUnit.Squarekilometre] = ("वर्ग किलोमिटर", 1000)
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
