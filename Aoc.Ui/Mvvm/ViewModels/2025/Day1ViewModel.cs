using Aoc.Solvers._2025;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Aoc.Ui.Mvvm.ViewModels._2025
{
    public partial class Day1ViewModel : ObservableObject
    {
        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(SolveFirstPuzzleCommand))]
        private string _firstPuzzleInput = string.Empty;

        [ObservableProperty]
        private string _firstPuzzleOutput = string.Empty;

        [ObservableProperty]
        private bool _isBusySolvingFirstPuzzle = false;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(SolveSecondPuzzleCommand))]
        private string _secondPuzzleInput = string.Empty;

        [ObservableProperty]
        private string _secondPuzzleOutput = string.Empty;

        [ObservableProperty]
        private bool _isBusySolvingSecondPuzzle = false;

        private bool CanSolveFirstPuzzle() => !string.IsNullOrWhiteSpace(FirstPuzzleInput);

        [RelayCommand(CanExecute = nameof(CanSolveFirstPuzzle))]
        private async Task SolveFirstPuzzle()
        {
            IsBusySolvingFirstPuzzle = true;

            FirstPuzzleOutput = await Day1Solver.SolveFirstPuzzle(FirstPuzzleInput);

            IsBusySolvingFirstPuzzle = false;
        }

        private bool CanSolveSecondPuzzle() => !string.IsNullOrWhiteSpace(SecondPuzzleInput);

        [RelayCommand(CanExecute = nameof(CanSolveSecondPuzzle))]
        private async Task SolveSecondPuzzle()
        {
            IsBusySolvingSecondPuzzle = true;

            SecondPuzzleOutput = await Day1Solver.SolveSecondPuzzle(SecondPuzzleInput);
            
            IsBusySolvingSecondPuzzle = false;
        }
    }
}
