namespace leetcode_sharp;

// 2551. Put Marbles in Bags
// https://leetcode.com/problems/put-marbles-in-bags/
public class S02551
{
    public long PutMarbles(int[] weights, int k)
    {
        var n = weights.Length;
        if (k == 1 || n == k)
        {
            return 0;
        }

        var candidates = new List<int>();
        
        for (var i = 0; i < n - 1; i++)
        {
            candidates.Add(weights[i] + weights[i + 1]);
        }

        candidates.Sort();

        var min = 0L;
        var max = 0L;

        for (var i = 0; i < k - 1; i++)
        {
            min += candidates[i];
            max += candidates[n - 2 - i];
        }

        return max - min;
    }
}