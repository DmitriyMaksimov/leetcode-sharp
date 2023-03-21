namespace leetcode_sharp;

// 36. Valid Sudoku
// https://leetcode.com/problems/valid-sudoku/
public class S00036
{
    public bool IsValidSudoku(char[][] board)
    {
        var row = new bool[9, 9];
        var col = new bool[9, 9];
        var grid = new bool[9, 9];

        for (var i = 0; i < board.Length; i++)
        {
            for (var j = 0; j < board[i].Length; j++)
            {
                if (board[i][j] != '.')
                {
                    var num = board[i][j] - '1';
                    var index = i / 3 * 3 + j / 3;
                    if (row[i, num] || col[j, num] || grid[index, num]) return false;
                    row[i, num] = true;
                    col[j, num] = true;
                    grid[index, num] = true;
                }
            }
        }

        return true;
    }
}