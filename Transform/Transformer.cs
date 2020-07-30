using Converter.Data;
using Converter.Models;
using System.Collections.Generic;
using System.Linq;

namespace Converter.Transform
{
    public class Transformer : ITransformer
    {

        private AppSettings AppSettings { get; set; }
        private readonly IEnumerable<IData> dataInstances;

        public Transformer(IEnumerable<IData> dataInstances, AppSettings settings)
        {
            this.dataInstances = dataInstances;
            AppSettings = settings;
        }

        public Unit GetUnit(string name)
        {
            IData dataInstance = dataInstances.FirstOrDefault(d => d.CurrentNamedInstance == AppSettings.CurrentDataInstance);
            (_, double RatioToBase) = dataInstance.GetUnitDescription(name);
            return new Unit(name, RatioToBase);
        }

        public double Transform(double valueToConvert, string fromUnit, string toUnit)
        {
            var from = GetUnit(fromUnit);
            var to = GetUnit(toUnit);
            var valueConverted = from.Convert(valueToConvert, to);
            
            return valueConverted;
        }

        public DropdownOption[] FetchDropdownUnitOptions()
        {
            IData dataInstance = dataInstances.FirstOrDefault(d => d.CurrentNamedInstance == AppSettings.CurrentDataInstance);
            return dataInstance.FetchDropdownUnitOptions();
        }
    }
}
