namespace leetcode_sharp;

// 3751. Total Waviness of Numbers in Range I
// https://leetcode.com/problems/total-waviness-of-numbers-in-range-i
public class S03751
{
    public int TotalWaviness(int num1, int num2)
    {
        return Enumerable.Range(num1, num2 - num1 + 1).Sum(GetWaviness);
    }

    private static int GetWaviness(int n)
    {
        if (n < 100)
        {
            return 0;
        }

        Span<int> digits = stackalloc int[6];

        var len = 0;
        var value = n;

        while (value > 0)
        {
            digits[len++] = value % 10;
            value /= 10;
        }

        var waviness = 0;

        for (var i = 1; i < len - 1; ++i)
        {
            var next = digits[i + 1] - digits[i];
            var prev = digits[i] - digits[i - 1];

            if ((prev > 0 && next < 0) || (prev < 0 && next > 0))
            {
                waviness++;
            }
        }

        return waviness;
    }
}