namespace leetcode_sharp;

// 1884. Egg Drop With 2 Eggs and N Floors
// https://leetcode.com/problems/egg-drop-with-2-eggs-and-n-floors
public class S01884
{
    private readonly int[] _dp = new int[1001];

    public int TwoEggDrop(int n)
    {
        if (_dp[n] != 0) return _dp[n];
        
        for (var i = 1; i <= n; ++i)
        {
            _dp[n] = Math.Min(_dp[n] == 0 ? n : _dp[n], 1 + Math.Max(i - 1, TwoEggDrop(n - i)));
        }

        return _dp[n];
    }
}