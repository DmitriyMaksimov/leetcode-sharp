namespace leetcode_sharp;

// 58. Length of Last Word
// https://leetcode.com/problems/length-of-last-word/
public class S00058
{
    public int LengthOfLastWord(string s)
    {
        var n = s.Length - 1;

        while (s[n] == ' ')
        {
            --n;
        }

        var len = 0;

        while (n >= 0 && s[n--] != ' ')
        {
            ++len;
        }
        
        
        return len;
    }
}