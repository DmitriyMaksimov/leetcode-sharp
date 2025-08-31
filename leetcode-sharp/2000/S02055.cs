namespace leetcode_sharp;

// 2055. Plates Between Candles
// https://leetcode.com/problems/plates-between-candles
public class S02055
{
    public int[] PlatesBetweenCandles(string s, int[][] queries)
    {
        var n = s.Length;
        var nextCandle = Enumerable.Repeat(n, n).ToArray();
        var prevCandle = Enumerable.Repeat(-1, n).ToArray();
        var prefixSum = new int[n];

        for (var i = 0; i < n; i++)
        {
            prevCandle[i] = s[i] == '*' ? (i == 0 ? prevCandle[i] : prevCandle[i - 1]) : i;

            var j = n - i - 1;
            nextCandle[j] = s[j] == '*' ? (i == 0 ? nextCandle[j] : nextCandle[j + 1]) : j;

            prefixSum[i] = (i == 0 ? 0 : prefixSum[i - 1]) + (s[i] == '*' ? 1 : 0);
        }

        var result = new int[queries.Length];

        for (var i = 0; i < queries.Length; i++)
        {
            var left = queries[i][0];
            var right = queries[i][1];
            var start = nextCandle[left] > right ? -1 : nextCandle[left];
            var end = prevCandle[right] < left ? -1 : prevCandle[right];

            result[i] = start == -1 || end == -1 || start >= end ? 0 : prefixSum[end] - prefixSum[start];
        }

        return result;
    }
}