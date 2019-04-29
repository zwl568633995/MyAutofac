using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAutofac
{
    public class ContainerBuilder : IContainerBuilder
    {
        private readonly Dictionary<Type, Resolver> _typePool;
        private Type _currentKey;
        public ContainerBuilder()
        {
            _typePool = new Dictionary<Type, Resolver>();
        }

        public IContainerBuilder RegisterTyper<T>()
        {
            _currentKey = typeof(T);
            var resolver = new Resolver { RealType = _currentKey };
            _typePool[_currentKey] = resolver;

            return this;
        }

        public IContainerBuilder AsImplementedInterfaces()
        {
            var interfaces = _currentKey.GetInterfaces();
            foreach (var inface in interfaces)
            {
                _typePool[inface] = _typePool[_currentKey];
            }

            return this;
        }

        public IContainer Builder()
        {
            var container = new Container(_typePool);

            return container;
        }

    }
}
