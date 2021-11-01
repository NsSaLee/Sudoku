using Sudoku.Lib.Models;
using Sudoku.Lib.Validations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.Lib.Business
{
    public static class Execute
    {
        public static bool SudokuSolver(char [,] board, GlobalValues globalValues)
        {
            Console.WriteLine($"Difficulty Level: { Validate.ValidateLevel(board)}");
			PrintBoard(board);
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
					if (globalValues.emptyChars.Any(x => x.Equals(board[i, j])))
                    {
                        for (var ch = '1'; ch <= '9'; ch++)
                        {
                            if (Validate.ValidateIteration(board,i,j,ch))
                            {
                                board[i, j] = ch;

                                if (SudokuSolver(board,globalValues))
                                {
                                    return true;
                                }
                                else
                                {
                                    board[i, j] = '.';
                                }
                            }
                        }
                        return false;
                    }
                }

            }
            return true;
        }

		public static void PrintBoard(char[,] board)
		{
			Console.WriteLine("*-----*-----*-----*");

			for (int i = 1; i < 10; ++i)
			{
				for (int j = 1; j < 10; ++j)
					Console.Write("|{0}", board[i - 1, j - 1]);

				Console.WriteLine("|");
				if (i % 3 == 0) Console.WriteLine("*-----*-----*-----*");
			}
		}
	}
}
