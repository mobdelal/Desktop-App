using Autofac;
using AutoMapper;
using E_Commerce.Application.Mapper;
using E_Commerce.Application.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce.Presentation
{
    public class AutoFac
    {
        public static IContainer Inject()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ProductService>().As<IproductService>();
            builder.Register(r => new MapperConfiguration(m =>
            m.AddProfile<AutoMapperProfile>()));
            builder.Register(c => c.Resolve<MapperConfiguration>().CreateMapper(c.Resolve)).As<IMapper>()
                .InstancePerDependency();
            return builder.Build();


        }
    }
}
