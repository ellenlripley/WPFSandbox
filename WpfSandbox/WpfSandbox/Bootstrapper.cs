namespace WpfSandbox
{
    public sealed class Bootstrapper
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(Bootstrapper).Name);

        public static void Initialize()
        {
            Log.Info("Initializing StructureMap");

            IoCFactory.ConfigureContainer();

           
        }
    }
}
