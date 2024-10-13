namespace leetcode_sharp;

// 1170. Compare Strings by Frequency of the Smallest Character
// https://leetcode.com/problems/compare-strings-by-frequency-of-the-smallest-character
public class S01170
{
    public int[] NumSmallerByFrequency(string[] queries, string[] words)
    {
        var prefixSum = new int[11];

        foreach (var word in words)
        {
            var count = GetFrequencyCount(word);
            prefixSum[count]++;
        }

        var sum = 0;
        for (var i = 0; i < prefixSum.Length; i++)
        {
            sum += prefixSum[i];
            prefixSum[i] = sum;
        }

        var result = new int[queries.Length];

        for (var i = 0; i < queries.Length; i++)
        {
            var count = GetFrequencyCount(queries[i]);
            result[i] = prefixSum[^1] - prefixSum[count];
        }

        return result;
    }

    private static int GetFrequencyCount(string word)
    {
        var count = new int[26];

        foreach (var ch in word)
        {
            count[ch - 'a']++;
        }

        return count.First(t => t != 0);
    }
}
