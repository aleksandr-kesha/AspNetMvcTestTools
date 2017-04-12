using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Ninject;

namespace MvcAppTestToolsProject.Infrastructure
{
    public class NinejctDependencyResolver : IDependencyResolver
    {
        private readonly IKernel _kernel;

        public NinejctDependencyResolver()
        {
            _kernel = new StandardKernel();
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        } 

        private void AddBindings()
        {
            _kernel.Bind<IValueCalculator>().To<ProductCalc>();
        }
    }
}