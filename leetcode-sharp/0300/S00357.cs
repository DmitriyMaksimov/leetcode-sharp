namespace leetcode_sharp;

// 357. Count Numbers with Unique Digits
// https://leetcode.com/problems/count-numbers-with-unique-digits
public class S00357
{
    public int CountNumbersWithUniqueDigits(int n)
    {
        if (n == 0)
        {
            return 1;
        }

        var result = 10;
        var uniqueDigits = 9;
        var availableNumber = 9;

        while (n-- > 1 && availableNumber > 0)
        {
            uniqueDigits *= availableNumber;
            result += uniqueDigits;
            availableNumber--;
        }

        return result;
    }
}
