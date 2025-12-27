using Aoc.Ui.Mvvm.ViewModels;
using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace Aoc.Ui
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

            // Register the view models.
            services.AddTransient<Mvvm.ViewModels._2024.Day1VM>();
            services.AddTransient<Mvvm.ViewModels._2025.Day1VM>();

            services.AddTransient<MainWindowVM>();

            return services.BuildServiceProvider();
        }
    }
}
