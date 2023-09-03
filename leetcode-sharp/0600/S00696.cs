namespace leetcode_sharp;

// 696. Count Binary Substrings
// https://leetcode.com/problems/count-binary-substrings/
public class S00696
{
    public int CountBinarySubstrings(string s)
    {
        var prevRunLength = 0;
        var curRunLength = 1;
        var result = 0;
        
        for (var i = 1; i < s.Length; i++)
        {
            if (s[i] == s[i - 1])
            {
                curRunLength++;
            }
            else
            {
                prevRunLength = curRunLength;
                curRunLength = 1;
            }

            if (prevRunLength >= curRunLength)
            {
                result++;
            }
        }
        
        return result;
    }
}