namespace leetcode_sharp;

// 9. Palindrome Number
// https://leetcode.com/problems/palindrome-number
public class S00009
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }

        var digits = x.ToString();

        for (var i = 0; i < digits.Length / 2; ++i)
        {
            if (digits[i] != digits[^(i + 1)])
            {
                return false;
            }
        }

        return true;
    }
}
