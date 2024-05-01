namespace leetcode_sharp;

// 3131. Find the Integer Added to Array I
// https://leetcode.com/problems/find-the-integer-added-to-array-i
public class S03131
{
    public int AddedInteger(int[] nums1, int[] nums2)
    {
        return nums2.Min() - nums1.Min();
    }
}