namespace leetcode_sharp;

// 1796. Second Largest Digit in a String
// https://leetcode.com/problems/second-largest-digit-in-a-string/
public class S01796
{
    public int SecondHighest(string s)
    {
        var first = -1;
        var second = -1;
        foreach (var digit in s.Where(char.IsDigit).Select(c => c - '0'))
        {
            if (digit > first)
            {
                second = first;
                first = digit;
            }
            else if (digit < first && digit > second)
            {
                second = digit;
            }
        }

        return second;
    }
}