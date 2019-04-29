using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandwritingAutofac.Fruits
{
    public class BananaFruitGetter : IFruitGetter
    {
        public string GetFruit()
        {
            return "香蕉";
        }
    }
}
