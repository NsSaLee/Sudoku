using Sudoku.Lib.Models;
using Sudoku.Lib.Validations;
using Sudoku.Lib.Business;

namespace Sudoku
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var _globalValues = new GlobalValues();

            try
            {
                var lines = File.ReadAllLines(@"C:\Sudoku.txt");
                var board = lines.ValidateInput(_globalValues);
                if (board is null)
                {
                    Console.WriteLine("Input file was not in correct format.");
                }
                else
                {
                    Execute.SudokuSolver(board,_globalValues);
                }
                Console.ReadKey();
            }
            catch (Exception)
            {
                throw ;
            }
        }
    }
}