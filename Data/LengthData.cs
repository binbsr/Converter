using Converter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Converter.Data
{
    public class LengthData : IData
    {   
        // Taking inch as base
        public Dictionary<string, (string NepaliUnicode, string ShortForm, string Details, double RatioToBase)> AvailableUnits => 
            new Dictionary<string, (string, string, string, double)>
        {   
            [LengthUnit.Angul] = ("अँगुल", "अँगुल", IData.NepalIndiaCustomaryLength, 0.75),
            [LengthUnit.Dhanurgrah] = ("धनुरग्रह", "धनुरग्रह", IData.NepalIndiaCustomaryLength, 3),

            [LengthUnit.Mile] = ("माइल", "mi", IData.ImperialAndUSCustomaryLength, 63360),
            [LengthUnit.KiloMetre] = ("किलोमिटर", "km", IData.SIUnit, 39370.07874),
            [LengthUnit.Metre] = ("मिटर", "m", IData.SIUnit, 39.37007874),
            [LengthUnit.Yard] = ("यार्ड", "yd", IData.ImperialAndUSCustomaryLength, 36),
            [LengthUnit.Feet] = ("फिट", "ft", IData.ImperialAndUSCustomaryLength,  12),
            [LengthUnit.Inch] = ("इन्च", "in", IData.ImperialAndUSCustomaryLength, 1),
            [LengthUnit.CentiMetre] = ("सेन्टिमिटर", "cm", IData.SIUnit, 0.3937007874),
            [LengthUnit.MilliMetre] = ("मिलिमिटर", "mm", IData.SIUnit, 0.0393700787),             
            [LengthUnit.MicroMetre] = ("माइक्रोमिटर", "µm", IData.SIUnit, 0.0000393700),
            [LengthUnit.NanoMetre] = ("नेनोमिटर", "nm", IData.SIUnit, 0.0000000393701)
        };

        public string CurrentNamedInstance => nameof(LengthData);

    }
}
