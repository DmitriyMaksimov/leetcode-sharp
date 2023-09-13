using System.Collections;

namespace leetcode_sharp;

// 2094. Finding 3-Digit Even Numbers
// https://leetcode.com/problems/finding-3-digit-even-numbers/
public class S02094
{
    public int[] FindEvenNumbers(int[] digits)
    {
        var result = new List<int>();

        for (var num = 100; num < 999; num += 2)
        {
            if (canBuildNumber(num, digits))
            {
                result.Add(num);
            }
        }

        return result.ToArray();
    }

    private static bool canBuildNumber(int num, IEnumerable<int> digits)
    {
        var ones = num % 10;
        var tens = num / 10 % 10;
        var hundreds = num / 100;

        var onesFound = false;
        var tensFound = false;
        var hundredsFound = false;

        foreach (var digit in digits)
        {
            if (!onesFound && ones == digit)
            {
                onesFound = true;
            }
            else if (!tensFound && tens == digit)
            {
                tensFound = true;
            }
            else if (!hundredsFound && hundreds == digit)
            {
                hundredsFound = true;
            }
                
            if (onesFound && tensFound && hundredsFound)
            {
                return true;
            }
        }

        return false;
    }
}