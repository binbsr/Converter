using Converter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Converter.Data
{
    public class WeightData : IData
    {   
        // Taking inch as base
        public Dictionary<string, (string NepaliUnicode, string ShortForm, char UnitFilterType, string Details, double RatioToBase)> GetAvailableUnits => new Dictionary<string, (string, string, char, string, double)>
        {   
            [LengthUnit.Angul] = ("Tola", "Tola", IData.Nepali, IData.NepalIndiaCustomaryLength, 0.75),
            [LengthUnit.Dhanurgrah] = ("धनुरग्रह", "धनुरग्रह", IData.Nepali, IData.NepalIndiaCustomaryLength, 3)
        };

        public string CurrentNamedInstance => nameof(LengthData);

        Dictionary<string, (string NepaliUnicode, string ShortForm, char UnitFilterType, string Details, double RatioToBase)> IData.GetAvailableUnits()
        {
            throw new NotImplementedException();
        }
    }
}
