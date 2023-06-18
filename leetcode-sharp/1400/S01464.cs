namespace leetcode_sharp;

// 1464. Maximum Product of Two Elements in an Array
// https://leetcode.com/problems/maximum-product-of-two-elements-in-an-array/
public class S01464
{
    public int MaxProduct(int[] nums)
    {
        var largestA = int.MinValue;
        var largestB = int.MinValue;

        foreach (var value in nums)
        {
            if (value > largestA)
            {
                largestB = largestA;
                largestA = value;
            }
            else if (value > largestB)
            {
                largestB = value;
            }
        }

        return (largestA - 1) * (largestB - 1);
    }
}