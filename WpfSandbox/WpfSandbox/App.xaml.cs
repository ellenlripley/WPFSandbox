using log4net;

using System.Windows;

namespace WpfSandbox
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        ILog Log = LogManager.GetLogger(typeof(App));

        protected override void OnStartup(StartupEventArgs e)
        {
            Log.Info("Starting WpfSandbox");
            Bootstrapper.Initialize();
            Log.Info("WpfSandbox started");
            base.OnStartup(e);
            ShutdownMode = ShutdownMode.OnMainWindowClose;
            Bootstrapper.Initialize();
        }
    }
}
