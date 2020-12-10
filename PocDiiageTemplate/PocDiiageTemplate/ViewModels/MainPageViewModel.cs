using PocDiiageTemplate.Views;
using Prism.Commands;
using Prism.Navigation;
using System.Windows.Input;

namespace PocDiiageTemplate.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            this.NavigateCommand = new DelegateCommand(Navigate);
        }

        public ICommand NavigateCommand { get; set; }

        async void Navigate()
        {
            await this.NavigationService.NavigateAsync(nameof(SecondPage));
        }
    }
}
