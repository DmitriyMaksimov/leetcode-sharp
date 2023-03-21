namespace leetcode_sharp;

// 349. Intersection of Two Arrays
// https://leetcode.com/problems/intersection-of-two-arrays/
public class S00349
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        var hashSet = nums1.ToHashSet();

        return nums2.Where(n => hashSet.Contains(n)).Distinct().ToArray();
    }
}