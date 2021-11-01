using Xunit;
using Sudoku.Lib.Business;
using Sudoku.Lib.Models;
using Sudoku.Lib.Validations;

namespace Sudoku.Tests
{
    public class Tests
    {
        [Theory]
        [InlineData(new object[] { new string[] { "51....,83\n8..416..0\n.........\n.985.461.\n...9.1...\n.642.357.\n.........\n6..157..4\n78.....96\n" } })]
        public void SudokuSolver_ShouldReturnNullForInvalidInput(string[] input)
        {
            var globalValues = new GlobalValues();
            var result = Validate.ValidateInput(input, globalValues);

            Assert.Null(result);
        }

        [Theory]
        [InlineData(new object[] { new string[] { "51.....83\n8..416..5\n.........\n.985.461.\n...9.1...\n.642.357.\n.........\n6..157..4\n78.....96\n" } })]
        public void ValidateLevel_ShouldReturnAnyLevel(string[] input)
        {
            var globalValues = new GlobalValues();
            var validatedInput = Validate.ValidateInput(input, globalValues);

            var result = Validate.ValidateLevel(validatedInput);
            Assert.IsType<Level>(result);
        }
    }
}