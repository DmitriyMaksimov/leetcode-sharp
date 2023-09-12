namespace leetcode_sharp;

// 1903. Largest Odd Number in String
// https://leetcode.com/problems/largest-odd-number-in-string/
public class S01903
{
    public string LargestOddNumber(string num)
    {
        var i = num.Length - 1;
        
        while (i >= 0 && (num[i] - '0') % 2 == 0)
        {
            i--;
        }

        return num[..(i + 1)];
    }
}