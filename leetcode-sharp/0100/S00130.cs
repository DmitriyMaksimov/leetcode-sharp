namespace leetcode_sharp;

// 130. Surrounded Regions
// https://leetcode.com/problems/surrounded-regions/
public class S00130
{
    private int _m;
    private int _n;
    private char[][] _board = null!;

    public void Solve(char[][] board)
    {
        _m = board.Length;
        _n = board[0].Length;
        _board = board;

        for (var i = 0; i < _m; i++)
        {
            for (var j = 0; j < _n; j++)
            {
                var visited = new bool[_m, _n];
                if (board[i][j] == 'O' && !isBoundaryReachable(i, j, visited))
                {
                    UpdateCells(i, j);
                }
            }
        }
    }

    private void UpdateCells(int row, int column)
    {
        if (row < 0 || column < 0 || row >= _m || column >= _n)
        {
            return;
        }

        if (_board[row][column] == 'X')
        {
            return;
        }

        _board[row][column] = 'X';
        UpdateCells(row - 1, column);
        UpdateCells(row + 1, column);
        UpdateCells(row, column - 1);
        UpdateCells(row, column + 1);
    }

    private bool isBoundaryReachable(int row, int column, bool[,] visited)
    {
        if (row < 0 || column < 0 || row >= _m || column >= _n)
        {
            return true;
        }

        if (_board[row][column] == 'X' || visited[row, column])
        {
            return false;
        }

        visited[row, column] = true;

        return isBoundaryReachable(row - 1, column, visited)
               || isBoundaryReachable(row, column - 1, visited)
               || isBoundaryReachable(row + 1, column, visited)
               || isBoundaryReachable(row, column + 1, visited);
    }
}