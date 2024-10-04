using ReviewApp.ViewModels.Commands;
using ReviewApp.ViewModels.Stores;
using System.Windows.Input;

namespace ReviewApp.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public ICommand NavigateCompanyCommand { get; }

        public HomeViewModel(NavigationStore navigationStore)
        {
            NavigateCompanyCommand = new NavigateCommand<CompanyViewModel>(navigationStore, () => new CompanyViewModel(navigationStore));
        }
    }
}
