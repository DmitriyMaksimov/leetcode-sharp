namespace leetcode_sharp;

// 37. Sudoku Solver
// https://leetcode.com/problems/sudoku-solver
public class S00037
{
    public void SolveSudoku(char[][] board)
    {
        Solve(board);
    }

    private static bool Solve(char[][] board)
    {
        for (var row = 0; row < board.Length; row++)
        {
            for (var col = 0; col < board[row].Length; col++)
            {
                if (board[row][col] != '.')
                {
                    continue;
                }

                for (var candidate = '1'; candidate <= '9'; candidate++)
                {
                    if (!IsValid(board, row, col, candidate))
                    {
                        continue;
                    }

                    board[row][col] = candidate;

                    if (Solve(board))
                    {
                        return true;
                    }

                    board[row][col] = '.';
                }

                return false;
            }
        }

        return true;
    }

    private static bool IsValid(char[][] board, int row, int col, char candidate)
    {
        for (var i = 0; i < 9; i++)
        {
            if (board[i][col] == candidate || board[row][i] == candidate)
            {
                return false;
            }

            var blockRow = 3 * (row / 3) + i / 3;
            var blockCol = 3 * (col / 3) + i % 3;

            if (board[blockRow][blockCol] == candidate)
            {
                return false;
            }
        }

        return true;
    }
}