namespace leetcode_sharp;

// 926. Flip String to Monotone Increasing
// https://leetcode.com/problems/flip-string-to-monotone-increasing/
public class S00926
{
    public int MinFlipsMonoIncr(string s)
    {
        var numberOf1Lhs = 0;
        var numberOf0Rhs = s.Count(c => c == '0');
        var min = numberOf0Rhs;
        
        foreach (var c in s)
        {
            if (c == '1')
            {
                numberOf1Lhs++;
            }
            else
            {
                numberOf0Rhs--;
            }
            
            min = Math.Min(min, numberOf1Lhs + numberOf0Rhs);
        }
        return min;
    }
}