using Autofac;
using Northwind.BusinessLayer.Concrete;
using Northwind.BusinessLayer.Abstract;
using Northwind.DataAccessLayer.Concrete.EntitityFramework;
using Northwind.DataAccessLayer.Abstract;
using Northwind.Core.Utilies.Security;
using Northwind.Core.Utilies.Security.Jwt;
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

             builder.RegisterType<AuthManager>().As<IAuthService>();
             builder.RegisterType<JwtHelper>().As<ITokenHelper>();
             
        }
    }
}