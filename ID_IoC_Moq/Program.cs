using System;
using Autofac;
using ID_IoC_Moq.Repos;
using ID_IoC_Moq.Services;

namespace ID_IoC_Moq
{
    class Program
    {
        static void Main(string[] args)
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<CatalogueService>();
            builder.RegisterType<CatalogueRepository>().AsImplementedInterfaces();
            IContainer container = builder.Build();

            using (ILifetimeScope scope = container.BeginLifetimeScope())
            {
                CatalogueService catalogueService = scope.Resolve<CatalogueService>();
                catalogueService.GetFavoriteProduct();
            }
        }
    }
}
