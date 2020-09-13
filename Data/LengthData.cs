using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Converter.Data
{
    public class LengthData : IData
    {
        // Taking inch as base
        public Dictionary<string, (string NepaliUnicode, string ShortForm, char UnitFilterType, string Details, double RatioToBase)> GetAvailableUnits()
        {
            bool isNepali = CultureInfo.CurrentCulture.Name == Culture.Nepali;

            var nonNepaliUnits = new Dictionary<string, (string, string, char, string, double)>
            {
                [LengthUnit.KiloMetre] = (isNepali ? "किलोमिटर" : "Kilometre", "km", IData.SI, IData.SIUnit, 39370.07874),
                [LengthUnit.Metre] = (isNepali ? "मिटर" : "Metre", "m", IData.SI, IData.SIUnit, 39.37007874),
                [LengthUnit.CentiMetre] = (isNepali ? "सेन्टिमिटर" : "Centimetre", "cm", IData.SI, IData.SIUnit, 0.3937007874015748),
                [LengthUnit.MilliMetre] = (isNepali ? "मिलिमिटर" : "Millimetre", "mm", IData.SI, IData.SIUnit, 0.03937007874015748),
                [LengthUnit.MicroMetre] = (isNepali ? "माइक्रोमिटर" : "Micrometre", "µm", IData.SI, IData.SIUnit, 0.00003937007874015748),
                [LengthUnit.NanoMetre] = (isNepali ? "नेनोमिटर" : "Nanometre", "nm", IData.SI, IData.SIUnit, 0.0000000393700787402),
                [LengthUnit.Mile] = (isNepali ? "माइल" : "Mile", "mi", IData.Imperial, IData.ImperialAndUSCustomaryLength, 63360),
                [LengthUnit.Yard] = (isNepali ? "यार्ड" : "Yard", "yd", IData.Imperial, IData.ImperialAndUSCustomaryLength, 36),
                [LengthUnit.Feet] = (isNepali ? "फिट" : "Feet", "ft", IData.Imperial, IData.ImperialAndUSCustomaryLength, 12),
                [LengthUnit.Inch] = (isNepali ? "इन्च" : "Inch", "in", IData.Imperial, IData.ImperialAndUSCustomaryLength, 1),
            };

            return isNepali ? GetNepalUnits().Concat(nonNepaliUnits).ToDictionary(x => x.Key, x => x.Value) : nonNepaliUnits;
        }

        private Dictionary<string, (string NepaliUnicode, string ShortForm, char UnitFilterType, string Details, double RatioToBase)> GetNepalUnits()
        {
            return new Dictionary<string, (string, string, char, string, double)>
            {
                [LengthUnit.Angul] = ("अँगुल", "अँगुल", IData.Nepali, IData.NepalIndiaCustomaryLength, 0.75),
                [LengthUnit.Dhanurgrah] = ("धनुरग्रह", "धनुरग्रह", IData.Nepali, IData.NepalIndiaCustomaryLength, 3)
            };
        }

        public string CurrentNamedInstance => nameof(LengthData);
    }
}
