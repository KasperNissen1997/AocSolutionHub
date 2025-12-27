using Aoc.Ui.Mvvm.ViewModels;
using CommunityToolkit.Mvvm.DependencyInjection;
using System.ComponentModel;
using System.Windows;

namespace Aoc.Ui.Mvvm.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowVM _vm;

        public MainWindow()
        {
            InitializeComponent();

            if (!DesignerProperties.GetIsInDesignMode(this))
                _vm = Ioc.Default.GetRequiredService<MainWindowVM>();

            DataContext = _vm;
        }
    }
}