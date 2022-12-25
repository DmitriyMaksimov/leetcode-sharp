namespace leetcode_sharp;

// 344. Reverse String
// https://leetcode.com/problems/reverse-string/
public class S00344
{
    public void ReverseString(char[] s)
    {
        var length = s.Length;
        for (var i = 0; i < length / 2; i++)
        {
            (s[i], s[length - i - 1]) = (s[length - i - 1], s[i]);
        }
    }
}