using Autofac;

namespace Module2HW4
{
    internal class Program
    {
        private static void Main()
        {
            var config = new DIConfig();
            var container = config.Build();
            var start = container.Resolve<Starter>();
            start.Run();
        }
    }
}
