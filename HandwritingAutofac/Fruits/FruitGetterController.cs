using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandwritingAutofac.Fruits
{
    public class FruitGetterController
    {
        private IFruitGetter _fruitGetter;
        public FruitGetterController(IFruitGetter fruitGetter)
        {
            this._fruitGetter = fruitGetter;
        }

        public string GetFruit()
        {
            return _fruitGetter.GetFruit();
        }
    }
}
