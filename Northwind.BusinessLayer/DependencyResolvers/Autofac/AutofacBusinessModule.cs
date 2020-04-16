using Autofac;
using Northwind.BusinessLayer.Concrete;
using Northwind.BusinessLayer.Abstract;
using Northwind.DataAccessLayer.Concrete.EntitityFramework;
using Northwind.DataAccessLayer.Abstract;

namespace Northwind.BusinessLayer.DependencyResolvers.Autofac
{
  public class AutofacBusinessModule : Module
    {
        public AutofacBusinessModule()
        {
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EfProductDal>().As<IProductDal>();
            builder.RegisterType<ProductManager>().As<IProductService>();  

             builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();         
        }
    }
}