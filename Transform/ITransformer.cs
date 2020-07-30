using Converter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Converter.Transform
{
    interface ITransformer
    {
        public double Transform(double valueToConvert, string fromUnit, string toUnit);
        public Unit GetUnit(string name);
        public DropdownOption[] FetchDropdownUnitOptions();
    }
}
