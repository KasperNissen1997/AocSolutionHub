using CommunityToolkit.Mvvm.ComponentModel;

namespace AocSolutionHub.Mvvm.ViewModels
{
    public class MainWindowVM : ObservableObject
    {
        public int Year { get; set; } = 2025;
        public int Day { get; set; } = 1;

        public MainWindowVM() { }
    }
}
