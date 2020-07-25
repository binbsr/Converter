using Converter.Models;

namespace Converter.Transformer
{
    public interface IUnitFactory
    {
        public Unit GetUnit(string name);
    }
}
