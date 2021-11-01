The Japanese Sudoku game has received a lot of attention lately.
If you are not familiar with it you can look it up on the web or in almost any daily newspaper. 
It is recommended that you know a little about the game before starting the assignment.

Part 1
Write a program that reads a Sudoku from a normal text file. The text file should be build by 9 rows with 9 characters each followed by an End of Line char. Each character is either a number (1-9) or some other character to symbolize an empty box. Store the read Sudoku in a suitable data structure.
Part 2
Write an algorithm that solves the Sudoku and verifies that there is only one solution and presents it in some way (can be a console printout or a windows form). Create some way of classifying the level of difficulty of the Sudoku (see the 4 attached examples)
Part 3
Implement an algorithm that creates a Sudoku with a unique solution.
 
Examples:
 
Easy:
51.....83
8..416..5
.........
.985.461.
...9.1...
.642.357.
.........
6..157..4
78.....96


Solution path: 
First I had to validate the inputs if it is in correct format. Tried to add possible different empty character posibilities.
After the input is valid and the board is not null, the difficulty level of the given board is calculated according to the placemnt
of the numbers, numbers in a row and the count of the given numbers. Then a counter is set so we can detect the different 
variations of solution can be detected. The board is printed before each move, and the moves are looping recursively for every
empty cell in the board by calculating each empty cells posiblity of having correct row. The correction is calculated by 
validating empty cells row, column and 3x3 cells. Finally the result and variations is printed. 3rd pard of the problem could
be calculated by simulating random boards in various difficulties by applying the SudokuSolver method so if the differentSolutionCounter
was greater than 1 then it is not a unique solution.
