namespace leetcode_sharp;

// 51. N-Queens
// https://leetcode.com/problems/n-queens/
public class S00051
{
    private readonly List<List<char>> _board = new();
    private readonly IList<IList<string>> _ans = new List<IList<string>>();
    private int[] _left = null!;
    private int[] _upperD = null!;
    private int[] _lowerD = null!;
    private int _n;

    private void solve(int col)
    {
        if (col == _n)
        {
            _ans.Add(_board.Select(chars => string.Join("", chars)).ToList());
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

    public IList<IList<string>> SolveNQueens(int n)
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
}