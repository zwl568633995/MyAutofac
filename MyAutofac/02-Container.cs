using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAutofac
{
    public class Container : IContainer
    {
        private readonly Dictionary<Type, Resolver> _typePool = new Dictionary<Type, Resolver>();

        public Container(Dictionary<Type, Resolver> typePool)
        {
            _typePool = typePool;
            foreach (var resolver in typePool.Values)
            {
                resolver.GetParameterInstance = Resolve;
            }
        }

        public T Resolve<T>()
        {
            return (T)_typePool[typeof(T)].GetInstance();
        }

        private object Resolve(Type type)
        {
            return _typePool[type].GetInstance();
        }
    }
}
