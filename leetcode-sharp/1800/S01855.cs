namespace leetcode_sharp;

// 1855. Maximum Distance Between a Pair of Values
// https://leetcode.com/problems/maximum-distance-between-a-pair-of-values/
public class S01855
{
    public int MaxDistance(int[] nums1, int[] nums2)
    {
        var i = 0;
        var j = 0;
        var result = 0;
        
        while (i < nums1.Length && j < nums2.Length)
        {
            if (nums1[i] > nums2[j])
            {
                ++i;
            }
            else
            {
                result = Math.Max(result, j - i);
                ++j;
            }
        }

        return result;
    }
}