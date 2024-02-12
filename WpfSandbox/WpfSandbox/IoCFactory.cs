using StructureMap;


namespace WpfSandbox
{
    internal class IoCFactory
    {
        internal static void ConfigureContainer()
        {
            var container = new Container();
            container.Configure(config =>
            {
                config.Scan(_ =>
                {
                    _.AssemblyContainingType<Bootstrapper>();
                    _.WithDefaultConventions();
                });

            });
        }
    }
}
