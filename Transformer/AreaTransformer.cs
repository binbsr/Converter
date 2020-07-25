using Converter.Data;
using Converter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Converter.Transformer
{
    public class AreaTransformer : ITransformer
    {
        private readonly IUnitFactory unitFactory;

        public AreaTransformer(IUnitFactory unitFactory)
        {
            this.unitFactory = unitFactory;
        }

        public double Transform(double valueToConvert, string fromUnit, string toUnit)
        {
            var from = unitFactory.GetUnit(fromUnit);
            var to = unitFactory.GetUnit(toUnit);
            var valueConverted = from.Convert(valueToConvert, to);
            
            return valueConverted;
        }
    }
}
