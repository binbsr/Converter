using Converter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Converter.Data
{
    public class LengthData : IData
    {
        // Taking foot(feet) as base
        public Dictionary<string, (string NepaliUnicode, double RatioToBase)> AvailableUnits => new Dictionary<string, (string, double)>
        {
            [LengthUnit.Mile] = ("माइल", 5280),
            [LengthUnit.KiloMetre] = ("किलोमिटर", 3280.839895),
            [LengthUnit.Metre] = ("मिटर", 3.280839895),
            [LengthUnit.Yard] = ("यार्ड", 3),
            [LengthUnit.Feet] = ("फिट", 1),
            [LengthUnit.Inch] = ("इन्च", 0.0833333333),
            [LengthUnit.CentiMetre] = ("सेन्टिमिटर", 0.032808399),
            [LengthUnit.MilliMetre] = ("मिलिमिटर", 0.0032808398950272),             
            [LengthUnit.MicroMetre] = ("माइक्रोमिटर", 0.000003280839895),
            [LengthUnit.NanoMetre] = ("नेनोमिटर", 0.00000000328084)
        };

        public string CurrentNamedInstance => nameof(LengthData);

    }
}
