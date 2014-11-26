using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity.Configuration;

namespace Calculator.Utilities
{
    public class DependencyResolver
    {
        private static DependencyResolver _instance = new DependencyResolver();

        private IUnityContainer _container;
        
        private DependencyResolver() { }

        public static DependencyResolver GetInstance()
        {
            //todo: critial section
            if (_instance._container == null)
            {
                _instance._container = new UnityContainer();
                _instance._container.LoadConfiguration();
            }
            return _instance;
        }               



        public T ResolveObject<T>()
        {
            
            return _container.Resolve<T>();
        }
    }
}
