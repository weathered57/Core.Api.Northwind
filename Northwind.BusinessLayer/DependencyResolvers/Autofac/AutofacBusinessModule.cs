using Autofac;
using Northwind.BusinessLayer.Concrete;
using Northwind.BusinessLayer.Abstract;
using Northwind.DataAccessLayer.Concrete.EntitityFramework;
using Northwind.DataAccessLayer.Abstract;
using Northwind.Core.Utilies.Security;
using Northwind.Core.Utilies.Security.Jwt;
using Autofac.Extras.DynamicProxy;
using Northwind.Core.Utilies.Interceptors;
using Castle.DynamicProxy;
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

             builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();
            builder.RegisterType<CategoryManager>().As<ICategoryService>();  

             builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();  
                

             builder.RegisterType<AuthManager>().As<IAuthService>();
             builder.RegisterType<JwtHelper>().As<ITokenHelper>();
             
             var assembly=System.Reflection.Assembly.GetExecutingAssembly();
             builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces().EnableInterfaceInterceptors(new ProxyGenerationOptions()
             {
               Selector= new AspectInterceptorSelector()
             }).SingleInstance();
        }
    }
}