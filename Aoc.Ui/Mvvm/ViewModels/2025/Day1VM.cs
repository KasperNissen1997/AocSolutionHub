using Aoc.Solvers._2025;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Aoc.Ui.Mvvm.ViewModels._2025
{
    public partial class Day1VM : ObservableObject
    {
        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(SolveCommand))]
        private string _input = string.Empty;

        private bool CanSolve() => !string.IsNullOrWhiteSpace(Input);

        [RelayCommand(CanExecute = nameof(CanSolve))]
        private void Solve()
        {
            Day1Solver.Solve(Input);
        }
    }
}
