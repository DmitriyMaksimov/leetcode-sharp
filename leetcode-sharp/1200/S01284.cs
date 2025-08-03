namespace leetcode_sharp;

// 1284. Minimum Number of Flips to Convert Binary Matrix to Zero Matrix
// https://leetcode.com/problems/minimum-number-of-flips-to-convert-binary-matrix-to-zero-matrix/
public class S01284
{
    private readonly Dictionary<string, int> _memo = new();
    private readonly HashSet<string> _visited = [];

    public int MinFlips(int[][] mat)
    {
        var res = helper(mat);
        return res == int.MaxValue ? -1 : res;
    }

    private int helper(int[][] mat)
    {
        if (isAllZeros(mat))
        {
            return 0;
        }

        var m = mat.Length;
        var n = mat[0].Length;


        var state = "";
        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                state += mat[i][j];
            }
        }

        if (_memo.TryGetValue(state, out var cached))
        {
            return cached;
        }

        if (_visited.Contains(state))
        {
            return int.MaxValue;
        }

        _visited.Add(state);
        var min = int.MaxValue;

        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                flip(mat, i, j);

                var small = helper(mat);
                if (small != int.MaxValue)
                {
                    min = Math.Min(min, 1 + small);
                }

                flip(mat, i, j);
            }
        }

        _visited.Remove(state);

        return _memo[state] = min;
    }

    private static bool isAllZeros(int[][] mat)
    {
        for (var i = 0; i < mat.Length; i++)
        {
            for (var j = 0; j < mat[0].Length; j++)
            {
                if (mat[i][j] == 1)
                {
                    return false;
                }
            }
        }

        return true;
    }

    private static void flip(int[][] mat, int i, int j)
    {
        mat[i][j] ^= 1;

        if (i - 1 >= 0)
        {
            mat[i - 1][j] ^= 1;
        }

        if (i + 1 < mat.Length)
        {
            mat[i + 1][j] ^= 1;
        }

        if (j - 1 >= 0)
        {
            mat[i][j - 1] ^= 1;
        }

        if (j + 1 < mat[0].Length)
        {
            mat[i][j + 1] ^= 1;
        }
    }
}