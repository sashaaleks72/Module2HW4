using Autofac;

namespace Module2HW4
{
    public class DIConfig
    {
        public IContainer Build()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MessageService>().As<IMessageService>();
            builder.RegisterType<MoveMotorcycleService>().As<IMotorcycle>();
            builder.RegisterType<MoveBicycleService>().As<IBicycle>();
            builder.RegisterType<Starter>();
            var container = builder.Build();

            return container;
        }
    }
}
