namespace leetcode_sharp;

// 3396. Minimum Number of Operations to Make Elements in Array Distinct
// https://leetcode.com/problems/minimum-number-of-operations-to-make-elements-in-array-distinct
public class S03396
{
    public int MinimumOperations(int[] nums)
    {
        var result = 0;

        while (true)
        {
            if (nums.Skip(result * 3).Distinct().Count() >= nums.Length - result * 3)
            {
                return result;
            }

            ++result;
        }
    }
}
