using Caliburn.Micro;

namespace PetGoodiesDesktopUI.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        private readonly LoginViewModel _loginViewModel;

        public ShellViewModel(LoginViewModel loginViewModel)
        {
            _loginViewModel = loginViewModel;
            ActivateItemAsync(_loginViewModel);
        }
    }
}
