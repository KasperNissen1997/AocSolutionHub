using CommunityToolkit.Mvvm.ComponentModel;

namespace AocSolutionHub.Mvvm.ViewModels
{
    public partial class MainWindowVM : ObservableObject
    {
        [ObservableProperty]
        private int _year = 2025;

        [ObservableProperty]
        private int _day = 2;

        public MainWindowVM() { }
    }
}
