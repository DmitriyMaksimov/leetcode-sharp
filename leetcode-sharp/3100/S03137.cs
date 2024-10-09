namespace leetcode_sharp;

// 3137. Minimum Number of Operations to Make Word K-Periodic
// https://leetcode.com/problems/minimum-number-of-operations-to-make-word-k-periodic
public class S03137
{
    public int MinimumOperationsToMakeKPeriodic(string word, int k)
    {
        Dictionary<string, int> m = [];

        for (var i = 0; i < word.Length; i += k)
        {
            var sub = word.Substring(i, Math.Min(k, word.Length - i));
            m[sub] = m.GetValueOrDefault(sub) + 1;
        }

        var max = m.Values.Max();

        return word.Length / k - max;
    }
}
