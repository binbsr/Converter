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
        private readonly IData data;

        public AreaUnitFactory(IData data)
        {
            this.data = data;
        }
        public Unit GetUnit(string name)
        {
            (_, double RatioToBase) = data.GetAreaUnit(name);
            return new Unit(name, RatioToBase);
        }
    }
}
