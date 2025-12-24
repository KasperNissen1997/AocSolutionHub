using AocSolutionHub.Mvvm.ViewModels;
using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace AocSolutionHub
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            IServiceProvider services = RegisterServices();

            Ioc.Default.ConfigureServices(services);
        }

        private IServiceProvider RegisterServices()
        {
            ServiceCollection services = new();

            // Register your services and ViewModels here
            //services.AddSingleton<ILogger, Logger>(); // Example service
            //services.AddSingleton<IMyService, MyService>();

            services.AddTransient<MainWindowVM>(); // Register your ViewModels

            // Build the provider and configure the Ioc instance
            return services.BuildServiceProvider();
        }
    }
}
