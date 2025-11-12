namespace leetcode_sharp;

// 2654. Minimum Number of Operations to Make All Array Elements Equal to 1
// https://leetcode.com/problems/minimum-number-of-operations-to-make-all-array-elements-equal-to-1
public class S02654
{
    public int MinOperations(int[] nums)
    {
        var n = nums.Length;
        var c = nums.Count(x => x == 1);
        if (c != 0)
        {
            return n - c;
        }

        var result = int.MaxValue;

        for (var i = 0; i < n; i++)
        {
            var g = nums[i];

            for (var j = i + 1; j < n; j++)
            {
                g = Gcd(g, nums[j]);

                if (g == 1)
                {
                    result = Math.Min(result, j - i + (n - 1));
                    break;
                }
            }
        }

        return result == int.MaxValue ? -1 : result;
    }
    
    private static int Gcd(int a, int b)
    {
        while (b != 0)
        {
            var temp = b;
            b = a % b;
            a = temp;
        }

        return a;
    }

}