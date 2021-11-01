using Sudoku.Lib.Models;

namespace Sudoku.Lib.Validations
{
    public static class Validate
    {
        public static char[,]? ValidateInput(this string[] lines, GlobalValues globalValues)
        {

            var board = new char[9, 9];

            if (lines.Length > 9 || lines.Length < 9)
            {
                return null;
            }

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Length > 9 || lines[i].Length < 9)
                {
                    return null;
                }

                for (int j = 0; j < lines[i].Length; j++)
                {
                    if (globalValues.digits.Any(x => x.Equals(lines[i][j])) || globalValues.emptyChars.Any(x => x.Equals(lines[i][j])))
                    {
                        board[i, j] = lines[i][j];
                    }
                }
            }
            return board;
        }

        public static bool ValidateIteration(char[,] board, int i, int j, char ch)
        {
            for (int it = 0; it < 9; it++)
            {
                if (board[it, j] != '.' && board[it, j] == ch)
                    return false;
                if (board[i, it] != '.' && board[i, it] == ch)
                    return false;
                if (board[3 * (i / 3) + it / 3, 3 * (j / 3) + it % 3] != '.' && board[3 * (i / 3) + it / 3, 3 * (j / 3) + it % 3] == ch)
                    return false;
            }
            return true;
        }

        public static Level ValidateLevel(char[,] board)
        {
            int counter = 0;
            int maxDigitCounter = 0;
            int maxDigitInRow = 0;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] != '.')
                    {
                        counter++;
                        maxDigitCounter++;
                    }
                }
                maxDigitInRow = maxDigitInRow > maxDigitCounter ? maxDigitInRow : maxDigitCounter;
                maxDigitCounter = 0;
            }

            switch (counter)
            {
                case > 31: return Level.Easy;
                        case > 27: return Level.Medium;
                case > 23:
                    if (maxDigitInRow > 3)
                        return Level.Hard;
                    else
                        return Level.Samurai;
                default: return Level.Samurai;
            }
        }
    }
}
