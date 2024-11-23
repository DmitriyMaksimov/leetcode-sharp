namespace leetcode_sharp;

// 1461. Check If a String Contains All Binary Codes of Size K
// https://leetcode.com/problems/check-if-a-string-contains-all-binary-codes-of-size-k
public class S01461
{
    public bool HasAllCodes(string s, int k)
    {
        var seen = new HashSet<string>();
        for (int i = k; i <= s.Length && seen.Count < 1 << k; ++i)
        {
            seen.Add(s.Substring(i - k, k));
        }

        return seen.Count == 1 << k;
    }
}
