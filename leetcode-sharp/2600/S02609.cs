namespace leetcode_sharp;

// 2609. Find the Longest Balanced Substring of a Binary String
// https://leetcode.com/problems/find-the-longest-balanced-substring-of-a-binary-string
public class S02609
{
    public int FindTheLongestBalancedSubstring(string s)
    {
        var max = 0;
        
        for (var i = 0; i < s.Length;)
        {
            var zeros = 0;
            var ones = 0;

            while (i < s.Length && s[i] == '0')
            {
                zeros++;
                i++;
            }

            while (i < s.Length && s[i] == '1' && zeros > ones)
            {
                ones++;
                i++;
                max = Math.Max(max, ones * 2);
            }

            while (i < s.Length && s[i] == '1')
            {
                i++;
            }
        }

        return max;
    }
}