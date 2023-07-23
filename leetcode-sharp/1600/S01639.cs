namespace leetcode_sharp;

// 1639. Number of Ways to Form a Target String Given a Dictionary
// https://leetcode.com/problems/number-of-ways-to-form-a-target-string-given-a-dictionary/
public class S01639
{
    private const int Modulo = 1_000_000_007;
    private readonly Dictionary<(int n, int m), int> _memo = new();
    private int _m;
    private int _n;
    private int[,] _charAtIndexCount;

    public int NumWays(string[] words, string target)
    {
        _m = words[0].Length;
        _n = target.Length;
        _charAtIndexCount = new int[128, _m];

        foreach (var word in words)
        {
            for (var i = 0; i < word.Length; i++)
                _charAtIndexCount[word[i], i] += 1; // Count the number of character `c` at index `i` of all words
        }

        return dp(0, 0, target);
    }

    private int dp(int k, int i, string target)
    {
        if (i == _n)
        {
            // Found target 
            return 1;
        }

        if (k == _m)
        {
            // No luck
            return 0;
        }

        if (_memo.ContainsKey((k, i)))
        {
            return _memo[(k, i)];
        }

        var c = target[i];

        long answer = dp(k + 1, i, target);

        if (_charAtIndexCount[c, k] > 0)
        {
            answer += (long) dp(k + 1, i + 1, target) * _charAtIndexCount[c, k];
            answer %= Modulo;
        }

        return _memo[(k, i)] = (int) answer;
    }
}