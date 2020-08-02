using Converter.Models;
using System.Collections.Generic;
using System.Linq;

namespace Converter.Data
{
    public class AreaData : IData
    {
        // Taking squarefeet as base
        public Dictionary<string, (string NepaliUnicode, string ShortForm, string Details, double RatioToBase)> AvailableUnits => 
            new Dictionary<string, (string, string, string, double)>
        {
            [AreaUnit.KhetMuri] = ("खेतमुरी", "खेतमुरी", IData.NepalCustomaryArea, 136900),
            [AreaUnit.Ropani] = ("रोपनी", "रोपनी", IData.NepalCustomaryArea, 5476),
            [AreaUnit.Bigha] = ("बिघा", "बिघा", IData.NepalIndiaCustomaryArea, 72900),
            [AreaUnit.Katha] = ("कठ्ठा", "कठ्ठा", IData.NepalIndiaCustomaryArea, 3645),
            [AreaUnit.Dhur] = ("धुर", "धुर", IData.NepalIndiaCustomaryArea, 182.25),
            [AreaUnit.Aana] = ("आना", "आना", IData.NepalCustomaryArea, 342.25),
            [AreaUnit.Paisa] = ("पैसा", "पैसा", IData.NepalCustomaryArea, 85.5625),
            [AreaUnit.Daam] = ("दाम", "दाम", IData.NepalCustomaryArea, 21.390625),
            [AreaUnit.Acre] = ("एकड", "Acre", IData.ImperialAndUSCustomaryArea, 43560),
            [AreaUnit.Hectare] = ("हेक्टर", "Hectare", IData.ImperialAndUSCustomaryArea, 107639.10417),
            [AreaUnit.SquareFeet] = ("वर्ग फिट", "ft<sup>2</sup>", IData.ImperialAndUSCustomaryArea, 1),
            [AreaUnit.SquareMetre] = ("वर्ग मिटर", "m<sup>2</sup>", IData.SIUnit, 10.76391),
            [AreaUnit.SquareKilometre] = ("वर्ग किलोमिटर", "km<sup>2</sup>", IData.SIUnit, 10763910.417)
        };

        public string CurrentNamedInstance => nameof(AreaData);
    }
}
