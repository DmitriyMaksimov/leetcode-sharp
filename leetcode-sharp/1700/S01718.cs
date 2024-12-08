namespace leetcode_sharp;

// 1718. Construct the Lexicographically Largest Valid Sequence
// https://leetcode.com/problems/construct-the-lexicographically-largest-valid-sequence
public class S01718
{
    private int[] _result = null!;
    private bool[] _visited = null!;
    private int _n;

    public int[] ConstructDistancedSequence(int n)
    {
        _result = new int[2 * n - 1];
        _visited = new bool[n + 1];
        _n = n;

        Backtrack(0);

        return _result;
    }

    private bool Backtrack(int i)
    {
        if (i == _result.Length)
        {
            return true;
        }

        if (_result[i] != 0)
        {
            return Backtrack(i + 1);
        }

        for (var j = _n; j > 0; j--)
        {
            if (_visited[j] || (j != 1 && (i + j >= _result.Length || _result[i + j] != 0)))
            {
                continue;
            }

            _result[i] = j;
            if (j != 1)
            {
                _result[i + j] = j;
            }

            _visited[j] = true;

            if (Backtrack(i + 1))
            {
                return true;
            }

            _result[i] = 0;
            if (j != 1)
            {
                _result[i + j] = 0;
            }

            _visited[j] = false;
        }

        return false;
    }
}
