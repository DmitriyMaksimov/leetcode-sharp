namespace leetcode_sharp;

// 3. Longest Substring Without Repeating Characters
// https://leetcode.com/problems/longest-substring-without-repeating-characters/
public class S00003
{
    public int LengthOfLongestSubstring(string s)
    {
        if (s.Length == 0) return 0;
        
        var maxLen = 1;
        var start = 0;
        var end = 0;
        var counts = new int[256];

        while (end < s.Length)
        {
            counts[s[end]]++;

            while (counts[s[end]] > 1)
            {
                counts[s[start++]]--;
            }

            ++end;
            maxLen = Math.Max(maxLen, end - start);
        }
        
        return maxLen;
    }
}