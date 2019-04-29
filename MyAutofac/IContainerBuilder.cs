using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAutofac
{
    public interface IContainerBuilder
    {
        IContainerBuilder RegisterTyper<T>();
        IContainerBuilder AsImplementedInterfaces();
        IContainer Builder();
    }
}
