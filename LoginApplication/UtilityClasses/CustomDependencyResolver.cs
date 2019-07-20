using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LoginApplication.Contracts;
using LoginApplication.Models;
using Ninject;

namespace LoginApplication.UtilityClasses
{
    public class CustomDependencyResolver : System.Web.Mvc.IDependencyResolver
    {
        Ninject.IKernel Kernel;
       public  CustomDependencyResolver()
        {
            Kernel = new StandardKernel();
            Kernel.Bind<LoginApplication.Contracts.IRepository<T>>().To<Reposioty<T>>();
        }

        public object GetService(Type serviceType)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            throw new NotImplementedException();
        }
    }
}