namespace leetcode_sharp;

// 2540. Minimum Common Value
// https://leetcode.com/problems/minimum-common-value/
public class S02540
{
    public int GetCommon(int[] nums1, int[] nums2)
    {
        foreach (var n in nums1)
        {
            if (Array.BinarySearch(nums2, n) >= 0)
            {
                return n;
            }
        }

        return -1;
    }
}