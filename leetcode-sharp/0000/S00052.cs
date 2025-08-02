namespace leetcode_sharp;

// 52. N-Queens II
// https://leetcode.com/problems/n-queens-ii/
public class S00052
{
    private readonly List<List<char>> _board = new();
    private int _ans;
    private int[] _left = null!;
    private int[] _upperD = null!;
    private int[] _lowerD = null!;
    private int _n;

    public int TotalNQueens(int n)
    {
        _n = n;
        _left = new int[n];
        _upperD = new int[2 * n - 1];
        _lowerD = new int[2 * n - 1];

        for (var i = 0; i < n; i++)
        {
            _board.Add(new List<char>(Enumerable.Repeat('.', n)));
        }

        solve(0);

        return _ans;
    }

    private void solve(int col)
    {
        if (col == _n)
        {
            ++_ans;
            return;
        }

        for (var row = 0; row < _n; row++)
        {
            if (_left[row] == 0 && _lowerD[row + col] == 0 && _upperD[_n - 1 + col - row] == 0)
            {
                _board[row][col] = 'Q';
                _left[row] = 1;
                _lowerD[row + col] = 1;
                _upperD[_n - 1 + col - row] = 1;

                solve(col + 1);

                _board[row][col] = '.';
                _left[row] = 0;
                _lowerD[row + col] = 0;
                _upperD[_n - 1 + col - row] = 0;
            }
        }
    }
}