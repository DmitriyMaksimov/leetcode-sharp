namespace leetcode_sharp;

// 3090. Maximum Length Substring With Two Occurrences
// https://leetcode.com/problems/maximum-length-substring-with-two-occurrences
public class S03090
{
    public int MaximumLengthSubstring(string s)
    {
        var counts = new int[26];
        var result = 0;

        for (int right = 0, left = 0; right < s.Length; ++right)
        {
            if (++counts[s[right] - 'a'] > 2)
            {
                while (counts[s[right] - 'a'] > 2)
                {
                    --counts[s[left] - 'a'];
                    ++left;
                }
            }

            result = Math.Max(result, right - left + 1);
        }

        return result;
    }
}