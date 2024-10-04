using ReviewApp.ViewModels.Commands;
using ReviewApp.ViewModels.Stores;
using System.Windows.Input;

namespace ReviewApp.ViewModels
{
    public class CompanyViewModel : ViewModelBase
    {
        public ICommand NavigateHomeCommand { get; }

        public CompanyViewModel(NavigationStore navigationStore) 
        {
            NavigateHomeCommand = new NavigateCommand<HomeViewModel>(navigationStore, () => new HomeViewModel(navigationStore));
        }
    }
}
