namespace leetcode_sharp;

// 3085. Minimum Deletions to Make String K-Special
// https://leetcode.com/problems/minimum-deletions-to-make-string-k-special
public class S03085
{
    public int MinimumDeletions(string word, int k)
    {
        var freqDict = new Dictionary<char, int>();
        foreach (var c in word)
        {
            freqDict[c] = freqDict.GetValueOrDefault(c) + 1;
        }

        var frequencies = freqDict.Values.OrderBy(f => f).ToList();

        var deleted = 0;
        var result = word.Length;

        for (var i = 0; i < frequencies.Count; i++)
        {
            var res = deleted;
            var minFreq = frequencies[i];

            for (var j = frequencies.Count - 1; j > i; j--)
            {
                if (frequencies[j] - minFreq <= k)
                {
                    break;
                }

                res += frequencies[j] - minFreq - k;
            }

            result = Math.Min(result, res);
            deleted += frequencies[i];
        }

        return result;
    }
}