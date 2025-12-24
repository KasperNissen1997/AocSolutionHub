using Aoc.Ui.Mvvm.ViewModels._2025;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Aoc.Mvvm.ViewModels
{
    public partial class MainWindowVM : ObservableObject
    {
        [ObservableProperty]
        private int _year = 2025;
        [ObservableProperty]
        private int _day = 2;
    }
}
