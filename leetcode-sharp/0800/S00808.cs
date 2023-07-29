namespace leetcode_sharp;

// 808. Soup Servings
// https://leetcode.com/problems/soup-servings/
public class S00808
{
    private double[,] _memo;

    public double SoupServings(int n)
    {
        // When N = 4801, the result = 0.999995382315, it should be 1.00000 after rounding
        if (n >= 4801)
        {
            return 1.00000;
        }

        _memo = new double[n + 1, n + 1];

        return dfs(n, n);
    }

    private double dfs(int a, int b)
    {
        switch (a)
        {
            case <= 0 when b <= 0:
                return 0.5;
            case <= 0:
                return 1.0;
        }

        if (b <= 0)
        {
            return 0;
        }

        if (_memo[a, b] > 0)
        {
            return _memo[a, b];
        }

        return _memo[a, b] = 0.25 * (dfs(a - 100, b) + dfs(a - 75, b - 25) + dfs(a - 50, b - 50) + dfs(a - 25, b - 75));
    }
}