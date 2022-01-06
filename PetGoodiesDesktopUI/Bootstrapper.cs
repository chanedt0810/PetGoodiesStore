using Caliburn.Micro;
using PetGoodiesDesktopUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace PetGoodiesDesktopUI
{
    public class Bootstrapper : BootstrapperBase
    {
        private SimpleContainer _container = new SimpleContainer();

        public Bootstrapper()
        {
            Initialize();
        }

        protected override void Configure()
        {
            // Instance of the container
            _container.Instance(_container);

            _container
                .Singleton<IWindowManager, WindowManager>() // Creates a single instance of WindowManager for the lifetime of the container
                .Singleton<IEventAggregator, EventAggregator>(); // Creates a single instance of EventAggregator for the lifetime of the container

            GetType().Assembly.GetTypes()
                .Where(type => type.IsClass)
                .Where(type => type.Name.EndsWith("ViewModel"))
                .ToList()
                .ForEach(viewModelType => _container.RegisterPerRequest(
                    viewModelType, viewModelType.ToString(), viewModelType));
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }

        protected override object GetInstance(Type service, string key)
        {
            return _container.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return _container.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            _container.BuildUp(instance);
        }
    }
}
