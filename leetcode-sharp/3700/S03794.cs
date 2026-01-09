namespace leetcode_sharp;

// 3794. Reverse String Prefix
// https://leetcode.com/problems/reverse-string-prefix
public class S03794
{
    public string ReversePrefix(string s, int k)
    {
        var chars = s.ToArray();

        Array.Reverse(chars, 0, k);
        
        return new string(chars);
    }
}