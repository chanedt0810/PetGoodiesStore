using Caliburn.Micro;
using PetGoodiesDesktopUI.ViewModels;
using System.Windows;

namespace PetGoodiesDesktopUI
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}
