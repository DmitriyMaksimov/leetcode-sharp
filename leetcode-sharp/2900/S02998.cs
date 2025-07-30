namespace leetcode_sharp;

// 2998. Minimum Number of Operations to Make X and Y Equal
// https://leetcode.com/problems/minimum-number-of-operations-to-make-x-and-y-equal
public class S02998
{
    private int[] _dp = null!;

    public int MinimumOperationsToMakeEqual(int x, int y)
    {
        _dp = Enumerable.Repeat(-1, 10011).ToArray();

        return Solve(x, y);
    }

    private int Solve(int x, int y)
    {
        // Base case: if x is already less than or equal to y, just increment to reach y
        if (x <= y) return y - x;

        // If result already computed, return it
        if (_dp[x] != -1) return _dp[x];

        // Start with the worst case: reducing by 1 each time
        var result = Math.Abs(x - y);

        // Try dividing by 5, rounding down or up as needed
        result = Math.Min(result, 1 + x % 5 + Solve(x / 5, y)); // Round down
        result = Math.Min(result, 1 + (5 - x % 5) + Solve(x / 5 + 1, y)); // Round up

        // Try dividing by 11, rounding down or up as needed
        result = Math.Min(result, 1 + x % 11 + Solve(x / 11, y)); // Round down
        result = Math.Min(result, 1 + (11 - x % 11) + Solve(x / 11 + 1, y)); // Round up

        // Store and return the computed result
        return _dp[x] = result;
    }
}