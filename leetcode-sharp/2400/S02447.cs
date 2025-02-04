namespace leetcode_sharp;

// 2447. Number of Subarrays With GCD Equal to K
// https://leetcode.com/problems/number-of-subarrays-with-gcd-equal-to-k
public class S02447
{
    public int SubarrayGCD(int[] nums, int k)
    {
        var result = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            var gcd = nums[i];

            for (var j = i; j < nums.Length; j++)
            {
                gcd = CalcGcd(gcd, nums[j]);
                if (gcd == k)
                {
                    result++;
                }
            }
        }

        return result;
    }

    private static int CalcGcd(int a, int b)
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
