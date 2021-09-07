using Converter.Data.Constants;
using System;
using System.Collections.Generic;

namespace Converter.Data
{
    public class WeightData : IData
    {   
        // Taking kg as base
        public Dictionary<string, (string NepaliUnicode, string ShortForm, char UnitFilterType, string Details, double RatioToBase)> GetAvailableUnits => new Dictionary<string, (string, string, char, string, double)>
        {   
            [WeighthUnit.Tola] = (nameof(WeighthUnit.Tola), nameof(WeighthUnit.Tola), IData.Nepali, IData.NepalIndiaCustomaryLength, 0.75),
            [LengthUnit.Angul] = ("Tola", "Tola", IData.Nepali, IData.NepalIndiaCustomaryLength, 0.75),
            [LengthUnit.Angul] = ("Tola", "Tola", IData.Nepali, IData.NepalIndiaCustomaryLength, 0.75),
            [LengthUnit.Angul] = ("Tola", "Tola", IData.Nepali, IData.NepalIndiaCustomaryLength, 0.75),
            [LengthUnit.Angul] = ("Tola", "Tola", IData.Nepali, IData.NepalIndiaCustomaryLength, 0.75),
        };

        

        public string CurrentNamedInstance => nameof(LengthData);

        Dictionary<string, (string NepaliUnicode, string ShortForm, char UnitFilterType, string Details, double RatioToBase)> IData.GetAvailableUnits()
        {
            throw new NotImplementedException();
        }
    }
}
