namespace leetcode_sharp;

// 1221. Split a String in Balanced Strings
// https://leetcode.com/problems/split-a-string-in-balanced-strings/
public class S01221
{
    public int BalancedStringSplit(string s)
    {
        var result = 0;
        var balance = 0;
        
        foreach (var c in s)
        {
            if (c == 'L')
            {
                ++balance;
            }
            else
            {
                --balance;
            }

            if (balance == 0)
            {
                ++result;
            }
        }
        
        return result;
    }
}