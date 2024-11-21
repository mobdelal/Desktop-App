using Autofac;
using AutoMapper;
using E_Commerce.Application.Contract;
using E_Commerce.Application.Mapper;
using E_Commerce.Application.service;
using E_Commerce.Context;
using E_Commerce.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login
{
    public class AutoFac
    {
        public static IContainer Inject()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ProductRepository>().As<IProductRepository>();
            builder.RegisterType<ProductService>().As<IproductService>();


            builder.RegisterType<CategoryRepository>().As<ICategoryRepository>();
            builder.RegisterType<CategoryService>().As<ICategoryService>();

            builder.RegisterType<UserRepository>().As<IUserRepository>();
            builder.RegisterType<UserService>().As<IUserService>();

            builder.RegisterType<EContext>().As<EContext>();
            builder.Register(r => new MapperConfiguration(m =>
            m.AddProfile<AutoMapperProfile>()));
            builder.Register(c => c.Resolve<MapperConfiguration>().CreateMapper(c.Resolve)).As<IMapper>()
                .InstancePerDependency();

            builder.RegisterType<OrderService>().As<IOrderService>();
            builder.RegisterType<OrderRepository>().As<IOrderRepository>();
            builder.RegisterType<OrderDetailRepository>().As<IOrderDetailRepository>();
            


            return builder.Build();

        }
    }
}
