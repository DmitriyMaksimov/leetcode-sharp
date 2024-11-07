namespace leetcode_sharp;

// 692. Top K Frequent Words
// https://leetcode.com/problems/top-k-frequent-words
public class S00692
{
    public IList<string> TopKFrequent(string[] words, int k)
    {
        Dictionary<string, int> freq = [];
        foreach (var word in words)
        {
            freq[word] = freq.GetValueOrDefault(word) + 1;
        }

        var sorted = freq.Keys.ToList();
        sorted.Sort((a, b) =>
        {
            if (freq[a] == freq[b])
            {
                return string.Compare(a, b, StringComparison.Ordinal);
            }

            return freq[b] - freq[a];
        });

        return sorted.Take(k).ToList();
    }
}
