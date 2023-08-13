namespace leetcode_sharp;

// 334. Increasing Triplet Subsequence
// https://leetcode.com/problems/increasing-triplet-subsequence/
public class S00334
{
    public bool IncreasingTriplet(int[] nums)
    {
        var max1 = int.MaxValue;
        var max2 = int.MaxValue;

        foreach (var n in nums)
        {
            if (n <= max1)
            {
                max1 = n;
            }
            else if (n <= max2)
            {
                max2 = n;
            }
            else
            {
                return true;
            }
        }

        return false;
    }
}