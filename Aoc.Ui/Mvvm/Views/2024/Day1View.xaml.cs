using Aoc.Ui.Mvvm.ViewModels._2024;
using CommunityToolkit.Mvvm.DependencyInjection;
using System.ComponentModel;
using System.Windows.Controls;

namespace Aoc.Ui.Mvvm.Views._2024
{
    /// <summary>
    /// Interaction logic for Day1View.xaml
    /// </summary>
    public partial class Day1View : Page
    {
        private readonly Day1ViewModel _vm;

        public Day1View()
        {
            InitializeComponent();

            if (!DesignerProperties.GetIsInDesignMode(this))
                _vm = Ioc.Default.GetRequiredService<Day1ViewModel>();

            DataContext = _vm;
        }
    }
}
