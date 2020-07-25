using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Converter.Transformer
{
    interface ITransformer
    {
        public double Transform(double valueToConvert, string fromUnit, string toUnit);
    }
}
