using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.Lib.Models
{
    public class GlobalValues
    {
        public char[] digits { get; } = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public char[] emptyChars { get; } = { '.' };
    }
}
