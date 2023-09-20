using System.Text;

namespace leetcode_sharp;

// 2259. Remove Digit From Number to Maximize Result
// https://leetcode.com/problems/remove-digit-from-number-to-maximize-result
public class S02259
{
    public string RemoveDigit(string number, char digit)
    {
        for (var i = 0; i < number.Length - 1; ++i)
        {
            if (number[i] == digit && number[i + 1] > digit)
            {
                return number[..i] + number[(i + 1)..];
            }
        }

        var lastDigitPosition = number.LastIndexOf(digit);
        return number[..lastDigitPosition] + number[(lastDigitPosition + 1)..];
    }
}