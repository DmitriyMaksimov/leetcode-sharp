namespace leetcode_sharp;

// 2160. Minimum Sum of Four Digit Number After Splitting Digits
// https://leetcode.com/problems/minimum-sum-of-four-digit-number-after-splitting-digits/
public class S02160
{
    public int MinimumSum(int num)
    {
        var sortedDigits = num.ToString().Order().Select(x => x - '0').ToArray();
        var num1 = sortedDigits[0] * 10 + sortedDigits[2];
        var num2 = sortedDigits[1] * 10 + sortedDigits[3];

        return num1 + num2;
    }
}