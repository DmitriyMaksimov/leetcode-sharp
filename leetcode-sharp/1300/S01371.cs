namespace leetcode_sharp;

// 1371. Find the Longest Substring Containing Vowels in Even Counts
// https://leetcode.com/problems/find-the-longest-substring-containing-vowels-in-even-counts
public class S01371
{
    public int FindTheLongestSubstring(string s)
    {
        var vowelMasks = new Dictionary<char, int> { ['a'] = 1 << 0, ['e'] = 1 << 1, ['i'] = 1 << 2, ['o'] = 1 << 3, ['u'] = 1 << 4 };
        var freq = new Dictionary<int, int> { [0] = 0 };
        var mask = 0;
        var result = 0;

        for (var i = 0; i < s.Length; i++)
        {
            if (vowelMasks.TryGetValue(s[i], out var vowelMask))
            {
                mask ^= vowelMask;
            }

            if (freq.TryGetValue(mask, out var value))
            {
                result = Math.Max(result, i + 1 - value);
            }
            else
            {
                freq[mask] = i + 1;
            }
        }

        return result;
    }
}
