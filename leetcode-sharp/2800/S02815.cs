namespace leetcode_sharp;

// 2815. Max Pair Sum in an Array
// https://leetcode.com/problems/max-pair-sum-in-an-array
public class S02815
{
    public int MaxSum(int[] nums)
    {
        var result = -1;

        var dictionary = new Dictionary<int, int>();

        foreach (var n in nums)
        {
            var maxDigit = getMaxDigit(n);

            if (dictionary.TryGetValue(maxDigit, out var value))
            {
                result = Math.Max(result, value + n);
                dictionary[maxDigit] = Math.Max(value, n);
            }
            else
            {
                dictionary[maxDigit] = n;
            }
        }

        return result;
    }

    private static int getMaxDigit(int num)
    {
        var maxDigit = 0;
        
        while (num != 0)
        {
            maxDigit = Math.Max(maxDigit, num % 10);
            num /= 10;
        }

        return maxDigit;
    }
}