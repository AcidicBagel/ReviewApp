using ReviewApp.ViewModels;
using ReviewApp.ViewModels.Stores;
using ReviewApp.Views.WPF.Windows;
using System.Windows;

namespace ReviewApp
{
    public partial class App : Application
    {
        private readonly string _connectionString = @"Data Source=.\SQLEXPRESS;DataBase=???;Integrated Security=True;Encrypt=False;";

        protected override void OnStartup(StartupEventArgs e)
        {
            NavigationStore navigationStore = new NavigationStore();
            navigationStore.CurrentViewModel = new CompanyViewModel(navigationStore);

            MainWindow mainWindow = new()
            {
                DataContext = new MainViewModel(navigationStore)
            };
            mainWindow.Show();

            base.OnStartup(e);
        }
    }
}
