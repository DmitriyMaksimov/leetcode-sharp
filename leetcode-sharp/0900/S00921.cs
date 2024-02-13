namespace leetcode_sharp;

// 921. Minimum Add to Make Parentheses Valid
// https://leetcode.com/problems/minimum-add-to-make-parentheses-valid
public class S00921
{
    public int MinAddToMakeValid(string s)
    {
        var left = 0;
        var right = 0;

        foreach (var c in s)
        {
            if (c == '(')
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