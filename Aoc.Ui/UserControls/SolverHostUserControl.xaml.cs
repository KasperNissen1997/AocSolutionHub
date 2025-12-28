using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Aoc.Ui.UserControls
{
    // Maybe one day this can be used as a fonudation for building a reusable control for displaying puzzle solvers?
    public partial class SolverHostUserControl : UserControl
    {
        public static readonly DependencyProperty TitleDependencyProperty =
            DependencyProperty.Register(
                nameof(Title),
                typeof(string),
                typeof(SolverHostUserControl),
                new PropertyMetadata(string.Empty));

        public static DependencyProperty FirstPuzzleInputDependencyProperty =
            DependencyProperty.Register(
                nameof(FirstPuzzleInput),
                typeof(string),
                typeof(SolverHostUserControl),
                new PropertyMetadata(string.Empty));

        public static DependencyProperty FirstPuzzleOutputDependencyProperty =
            DependencyProperty.Register(
                nameof(FirstPuzzleOutput),
                typeof(string),
                typeof(SolverHostUserControl),
                new PropertyMetadata(string.Empty));

        public static DependencyProperty IsBusySolvingFirstPuzzleDependencyProperty =
            DependencyProperty.Register(
                nameof(IsBusySolvingFirstPuzzle),
                typeof(bool),
                typeof(SolverHostUserControl),
                new PropertyMetadata(false));

        public static DependencyProperty SolveFirstPuzzleCommandDependencyProperty =
            DependencyProperty.Register(
                nameof(SolveFirstPuzzleCommand),
                typeof(ICommand),
                typeof(SolverHostUserControl),
                new PropertyMetadata(null));

        public static DependencyProperty SecondPuzzleInputDependencyProperty =
            DependencyProperty.Register(
                nameof(SecondPuzzleInput),
                typeof(string),
                typeof(SolverHostUserControl),
                new PropertyMetadata(string.Empty));

        public static DependencyProperty SecondPuzzleOutputDependencyProperty =
            DependencyProperty.Register(
                nameof(SecondPuzzleOutput),
                typeof(string),
                typeof(SolverHostUserControl),
                new PropertyMetadata(string.Empty));

        public static DependencyProperty IsBusySolvingSecondPuzzleDependencyProperty =
            DependencyProperty.Register(
                nameof(IsBusySolvingSecondPuzzle),
                typeof(bool),
                typeof(SolverHostUserControl),
                new PropertyMetadata(false));

        public static DependencyProperty SolveSecondPuzzleCommandDependencyProperty =
            DependencyProperty.Register(
                nameof(SolveSecondPuzzleCommand),
                typeof(ICommand),
                typeof(SolverHostUserControl),
                new PropertyMetadata(null));

        public string Title
        {
            get => (string) GetValue(TitleDependencyProperty);
            set => SetValue(TitleDependencyProperty, value);
        }

        public string FirstPuzzleInput
        {
            get => (string) GetValue(FirstPuzzleInputDependencyProperty);
            set => SetValue(FirstPuzzleInputDependencyProperty, value);
        }

        public string FirstPuzzleOutput
        {
            get => (string) GetValue(FirstPuzzleOutputDependencyProperty);
            set => SetValue(FirstPuzzleOutputDependencyProperty, value);
        }

        public bool IsBusySolvingFirstPuzzle
        {
            get => (bool) GetValue(IsBusySolvingFirstPuzzleDependencyProperty);
            set => SetValue(IsBusySolvingFirstPuzzleDependencyProperty, value);
        }

        public ICommand SolveFirstPuzzleCommand
        {
            get => (ICommand) GetValue(SolveFirstPuzzleCommandDependencyProperty);
            set => SetValue(SolveFirstPuzzleCommandDependencyProperty, value);
        }

        public string SecondPuzzleInput
        {
            get => (string) GetValue(SecondPuzzleInputDependencyProperty);
            set => SetValue(SecondPuzzleInputDependencyProperty, value);
        }

        public string SecondPuzzleOutput
        {
            get => (string) GetValue(SecondPuzzleOutputDependencyProperty);
            set => SetValue(SecondPuzzleOutputDependencyProperty, value);
        }

        public bool IsBusySolvingSecondPuzzle
        {
            get => (bool) GetValue(IsBusySolvingSecondPuzzleDependencyProperty);
            set => SetValue(IsBusySolvingSecondPuzzleDependencyProperty, value);
        }

        public ICommand SolveSecondPuzzleCommand
        {
            get => (ICommand) GetValue(SolveSecondPuzzleCommandDependencyProperty);
            set => SetValue(SolveSecondPuzzleCommandDependencyProperty, value);
        }

        public SolverHostUserControl()
        {
            InitializeComponent();
        }
    }
}
