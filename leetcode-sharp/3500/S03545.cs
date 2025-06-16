namespace leetcode_sharp;

// 3545. Minimum Deletions for At Most K Distinct Characters
// https://leetcode.com/problems/minimum-deletions-for-at-most-k-distinct-characters
public class S03545
{
    public int MinDeletion(string s, int k)
    {
        var frequencies = new Dictionary<char, int>();

        foreach (var c in s)
        {
            frequencies[c] =  frequencies.GetValueOrDefault(c) + 1;
        }

        return frequencies.Values.Order().Take(frequencies.Count - k).Sum();
    }
}
