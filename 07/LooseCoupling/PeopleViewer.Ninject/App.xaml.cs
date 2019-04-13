using Common;
using Ninject;
using PersonRepository.CSV;
using System.Windows;

namespace PeopleViewer.Ninject
{
    public partial class App : Application
    {
        IKernel Container = new StandardKernel();

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            //            Container.Bind<IPersonRepository>().To<ServiceRepository>();
            Container.Bind<IPersonRepository>().To<CSVRepository>();
            Application.Current.MainWindow = Container.Get<MainWindow>();

            Application.Current.MainWindow.Show();
        }
    }
}
