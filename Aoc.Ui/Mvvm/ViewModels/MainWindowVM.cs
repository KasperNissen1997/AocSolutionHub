using Aoc.Ui.Enums;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Aoc.Ui.Mvvm.ViewModels
{
    public partial class MainWindowVM : ObservableObject
    {
        [ObservableProperty]
        private PageCode _activePageCode = Constants.DefaultPageCode;
    }
}
