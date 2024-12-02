namespace leetcode_sharp;

// 424. Longest Repeating Character Replacement
// https://leetcode.com/problems/longest-repeating-character-replacement
public class S00424
{
    public int CharacterReplacement(string s, int k)
    {
        var len = s.Length;
        var count = new int[26];
        var start = 0;
        var maxCount = 0;
        var maxLength = 0;

        for (var end = 0; end < len; end++)
        {
            maxCount = Math.Max(maxCount, ++count[s[end] - 'A']);

            while (end - start + 1 - maxCount > k)
            {
                count[s[start] - 'A']--;
                start++;
            }

            maxLength = Math.Max(maxLength, end - start + 1);
        }

        return maxLength;
    }
}
