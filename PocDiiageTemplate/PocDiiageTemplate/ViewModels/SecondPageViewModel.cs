using Prism.Navigation;

namespace PocDiiageTemplate.ViewModels
{
    public class SecondPageViewModel : ViewModelBase
    {
        public SecondPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Second Page";
        }
    }
}
