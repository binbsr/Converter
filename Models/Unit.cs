using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Converter.Models
{
    public class Unit
    {
        public string Name { get; }
        public double Ratio { get; }

        public Unit(string name, double ratio)
        {
            Name = name;
            Ratio = ratio;
        }

        public double Convert(double value, Unit toUnit)
        {
            return (value * Ratio) / toUnit.Ratio;
        }
    }
}
