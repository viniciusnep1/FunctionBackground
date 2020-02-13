using Autofac;
using services.repositories;
using core.events;
using MediatR;
using core.seedwork;
using core.bus;
using services.services.calculos;
using hateoas.infrastructure;

namespace services
{
    public class ServicesModule : Module
    {
        protected override void Load(ContainerBuilder containerBuilder)
        {
            // Infra
            containerBuilder.RegisterType<InMemoryBus>().As<IMediatorHandler>();

            containerBuilder.RegisterType<HateoasOptionsService>().As<IHateoasOptionsService>();
            containerBuilder.RegisterType<XptoRepository>();

            //Repositories
            containerBuilder.RegisterType<StoredEventRepository>().SingleInstance();
            containerBuilder.RegisterType<EventStoreRepository>().As<IEventStore>().SingleInstance();

            //Queries
            containerBuilder.RegisterType<queryVolumesPlanejadosProduzidos>();

            //Commands


        }
    }
}
