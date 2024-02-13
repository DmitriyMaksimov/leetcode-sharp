namespace leetcode_sharp;

// 921. Minimum Add to Make Parentheses Valid
// https://leetcode.com/problems/minimum-add-to-make-parentheses-valid
public class S00921
{
    public int MinAddToMakeValid(string s)
    {
        var left = 0;
        var right = 0;

        for (var i = 0; i < s.Length; ++i)
        {
            if (s[i] == '(')
            {
                right++;
            }
            else if (right > 0)
            {
                right--;
            }
            else
            {
                left++;
            }
        }

        return left + right;
    }
}