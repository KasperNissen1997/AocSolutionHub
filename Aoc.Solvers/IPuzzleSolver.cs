namespace Aoc.Solvers
{
    public interface IPuzzleSolver
    {
        public static abstract Task<string> SolveFirstPuzzle(string input);

        public static abstract Task<string> SolveSecondPuzzle(string input);
    }
}