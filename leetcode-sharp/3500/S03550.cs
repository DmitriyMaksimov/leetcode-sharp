namespace leetcode_sharp;

// 3550. Smallest Index With Digit Sum Equal to Index
// https://leetcode.com/problems/smallest-index-with-digit-sum-equal-to-index
public class S03550
{
    public int SmallestIndex(int[] nums)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            if (SumOfDigits(nums[i]) == i)
            {
                return i;
            }
        }

        return -1;
    }

    private static int SumOfDigits(int n)
    {
        var sum = 0;
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }

        return sum;
    }
}
