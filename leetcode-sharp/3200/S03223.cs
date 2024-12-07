namespace leetcode_sharp;

// 3223. Minimum Length of String After Operations
// https://leetcode.com/problems/minimum-length-of-string-after-operations
public class S03223
{
    public int MinimumLength(string s)
    {
        var n = s.Length;
        var count = 0;
        Dictionary<char, int> dictionary = [];

        for (var i = 0; i < n; i++)
        {
            dictionary[s[i]] = dictionary.GetValueOrDefault(s[i]) + 1;

            if (dictionary[s[i]] > 2)
            {
                count += 2;
                dictionary[s[i]] -= 2;
            }
        }

        return n - count;
    }
}
