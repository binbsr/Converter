using System.Collections.Generic;

namespace Converter.Data
{
    public class LengthData : IData
    {
        // Taking inch as base
        public Dictionary<string, (string NepaliUnicode, string ShortForm, char UnitFilterType, string Details, double RatioToBase)> GetAvailableUnits()
        {
            //bool isNepali = CultureInfo.CurrentCulture.Name == Culture.Nepali;

            var units = new Dictionary<string, (string, string, char, string, double)>
            {
                [LengthUnit.KiloMetre] = ("Kilometre", "km", IData.SI, IData.SIUnit, 39370.07874),
                [LengthUnit.Metre] = ("Metre", "m", IData.SI, IData.SIUnit, 39.37007874),
                [LengthUnit.CentiMetre] = ("Centimetre", "cm", IData.SI, IData.SIUnit, 0.3937007874015748),
                [LengthUnit.MilliMetre] = ("Millimetre", "mm", IData.SI, IData.SIUnit, 0.03937007874015748),
                [LengthUnit.MicroMetre] = ("Micrometre", "µm", IData.SI, IData.SIUnit, 0.00003937007874015748),
                [LengthUnit.NanoMetre] = ("Nanometre", "nm", IData.SI, IData.SIUnit, 0.0000000393700787402),
                [LengthUnit.Mile] = ("Mile", "mi", IData.Imperial, IData.ImperialAndUSCustomaryLength, 63360),
                [LengthUnit.Yard] = ("Yard", "yd", IData.Imperial, IData.ImperialAndUSCustomaryLength, 36),
                [LengthUnit.Feet] = ("Feet", "ft", IData.Imperial, IData.ImperialAndUSCustomaryLength, 12),
                [LengthUnit.Inch] = ("Inch", "in", IData.Imperial, IData.ImperialAndUSCustomaryLength, 1),
                [LengthUnit.Angul] = ("अँगुल", "अँगुल", IData.Nepali, IData.NepalIndiaCustomaryLength, 0.75),
                [LengthUnit.Dhanurgrah] = ("धनुरग्रह", "धनुरग्रह", IData.Nepali, IData.NepalIndiaCustomaryLength, 3),
                [LengthUnit.Dhanurmushti] = ("धनुरमुश्ती", "धनुरमुश्ती", IData.Nepali, IData.NepalIndiaCustomaryLength, 6),
                [LengthUnit.Bittaa] = ("बित्ता", "बित्ता", IData.Nepali, IData.NepalIndiaCustomaryLength, 9),
                [LengthUnit.Haath] = ("हात", "हात", IData.Nepali, IData.NepalIndiaCustomaryLength, 18),
                [LengthUnit.Dhanush] = ("धनुष (Bow)", "धनुष", IData.Nepali, IData.NepalIndiaCustomaryLength, 72),
                [LengthUnit.Haath] = ("कोश", "कोश", IData.Nepali, IData.NepalIndiaCustomaryLength, 144000),
                [LengthUnit.Dhanush] = ("योजन", "योजन", IData.Nepali, IData.NepalIndiaCustomaryLength, 576000)
            };

            return units;
        }

        public string CurrentNamedInstance => nameof(LengthData);
    }
}
