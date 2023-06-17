namespace leetcode_sharp;

// 1913. Maximum Product Difference Between Two Pairs
// https://leetcode.com/problems/maximum-product-difference-between-two-pairs/
public class S01913
{
    public int MaxProductDifference(int[] nums)
    {
        var largestA = int.MinValue;
        var largestB = int.MinValue;
        var smallestA = int.MaxValue;
        var smallestB = int.MaxValue;

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

            if (value < smallestA)
            {
                smallestB = smallestA;
                smallestA = value;
            }
            else if (value < smallestB)
            {
                smallestB = value;
            }
        }

        return largestA * largestB - smallestA * smallestB;
    }
}