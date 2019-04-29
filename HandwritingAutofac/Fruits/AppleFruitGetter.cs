using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandwritingAutofac.Fruits
{
    public class AppleFruitGetter : IFruitGetter
    {
        public string GetFruit()
        {
            return "苹果";
        }
    }
}
