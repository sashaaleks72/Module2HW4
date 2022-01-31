using Autofac;

namespace Module2HW4
{
    public class StartConfig
    {
        public void Build()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MessageService>().As<IMessage>();
            builder.RegisterType<MoveMotorcycleService>().As<IMotorcycle>();
            builder.RegisterType<MoveBicycleService>().As<IBicycle>();
            builder.RegisterType<Starter>();
            var container = builder.Build();

            var start = container.Resolve<Starter>();
            start.Run();
        }
    }
}
