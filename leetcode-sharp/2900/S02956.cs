namespace leetcode_sharp;

// 2956. Find Common Elements Between Two Arrays
// https://leetcode.com/problems/find-common-elements-between-two-arrays
public class S02956
{
    public int[] FindIntersectionValues(int[] nums1, int[] nums2)
    {
        var set1 = new HashSet<int>(nums1);
        var set2 = new HashSet<int>(nums2);
        return [nums1.Count(x => set2.Contains(x)), nums2.Count(x => set1.Contains(x))];
    }
}