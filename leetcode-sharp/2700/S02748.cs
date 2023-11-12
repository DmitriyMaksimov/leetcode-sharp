namespace leetcode_sharp;

// 2748. Number of Beautiful Pairs
// https://leetcode.com/problems/number-of-beautiful-pairs
public class S02748
{
    public int CountBeautifulPairs(int[] nums)
    {
        var firstAndLasts = nums.Select(getFirstAndLast).ToArray();

        var result = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                if (gcd(firstAndLasts[i].first, firstAndLasts[j].last) == 1)
                {
                    result++;
                }
            }
        }

        return result;
    }

    private static (int first, int last) getFirstAndLast(int n)
    {
        var l = n % 10;

        while (n > 9)
        {
            n /= 10;
        }

        return (n, l);
    }

    static int gcd(int a, int b)
    {
        return b == 0 ? a : gcd(b, a % b);
    }
}