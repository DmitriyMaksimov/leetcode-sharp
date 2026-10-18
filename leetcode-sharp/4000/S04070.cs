namespace leetcode_sharp;

// 4070. Minimum Rotations to Dial a Number I
// https://leetcode.com/problems/minimum-rotations-to-dial-a-number-i
public class S04070
{
    public int MinRotations(string s)
    {
        var fromDigit = 0;
        var result = 0;
        
        foreach (var ch in s)
        {
            var toDigit = (ch - '0');
            var diff = Math.Abs(toDigit - fromDigit);
        
            result += Math.Min(diff, 10 - diff);
            fromDigit = toDigit;
        }

        return result;
    }
}