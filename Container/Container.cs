using System;
using System.Linq;

namespace DeveloperSample.Container
{
    public class Container
    {
        private Type _implType;
        private Type _interfaceType;
        public void Bind(Type interfaceType, Type implementationType)
        {
            var implementsInterface = implementationType.GetInterfaces().Contains(interfaceType);
            if (!implementsInterface) throw new Exception("Implementation class does not implement the interface provided");
            _implType = implementationType;
            _interfaceType = interfaceType;
        }
        public T Get<T>()
        {
            if (typeof(T) == _interfaceType)
                return (T)Activator.CreateInstance(_implType);
            throw new Exception("Invalid implementation class");
        }
    }
}