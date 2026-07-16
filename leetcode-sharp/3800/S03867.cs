namespace leetcode_sharp;

// 3867. Sum of GCD of Formed Pairs
// https://leetcode.com/problems/sum-of-gcd-of-formed-pairs
public class S03867
{
    public long GcdSum(int[] nums)
    {
        var prefixGcd = new int[nums.Length];
        var max = -1;

        for (var i = 0; i < nums.Length; i++)
        {
            max = Math.Max(max, nums[i]);
            prefixGcd[i] = Gcd(max, nums[i]);
        }

        Array.Sort(prefixGcd);

        long sum = 0;
        var left = 0;
        var right = nums.Length - 1;

        while (left < right)
        {
            sum += Gcd(prefixGcd[left], prefixGcd[right]);
            left++;
            right--;
        }

        return sum;
    }

    private static int Gcd(int a, int b)
    {
        while (b != 0)
        {
            (a, b) = (b, a % b);
        }

        return a;
    }
}