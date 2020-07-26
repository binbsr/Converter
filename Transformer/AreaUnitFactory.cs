using Converter.Data;
using Converter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Converter.Transformer
{
    public class AreaUnitFactory : IUnitFactory
    {
        public Unit GetUnit(string name)
        {
            (_, double RatioToBase) = AreaData.GetAreaUnit(name);
            return new Unit(name, RatioToBase);
        }
    }
}
