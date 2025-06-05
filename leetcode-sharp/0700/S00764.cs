namespace leetcode_sharp;

// 764. Largest Plus Sign
// https://leetcode.com/problems/largest-plus-sign
public class S00764
{
    public int OrderOfLargestPlusSign(int n, int[][] mines)
    {
        var matrix = new int[n, n];

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < n; j++)
            {
                matrix[i, j] = 1;
            }
        }

        foreach (var mine in mines)
        {
            var x = mine[0];
            var y = mine[1];
            matrix[x, y] = 0;
        }

        var left = new int[n, n];
        var right = new int[n, n];
        var top = new int[n, n];
        var bottom = new int[n, n];

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < n; j++)
            {
                left[i, j] = right[i, j] = top[i, j] = bottom[i, j] = matrix[i, j];
            }
        }

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < n; j++)
            {
                var x = n - i - 1;
                var y = n - j - 1;

                if (i > 0 && top[i, j] > 0)
                {
                    top[i, j] += top[i - 1, j];
                }

                if (j > 0 && left[i, j] > 0)
                {
                    left[i, j] += left[i, j - 1];
                }

                if (x < n - 1 && bottom[x, y] > 0)
                {
                    bottom[x, y] += bottom[x + 1, y];
                }

                if (y < n - 1 && right[x, y] > 0)
                {
                    right[x, y] += right[x, y + 1];
                }
            }
        }

        var result = 0;

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < n; j++)
            {
                result = Math.Max(result, Math.Min(Math.Min(left[i, j], right[i, j]), Math.Min(top[i, j], bottom[i, j])));
            }
        }

        return result;
    }
}
