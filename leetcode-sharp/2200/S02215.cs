namespace leetcode_sharp;

// 2215. Find the Difference of Two Arrays
// https://leetcode.com/problems/find-the-difference-of-two-arrays/
public class S02215
{
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        var hashSet1 = nums1.ToHashSet();
        var hashSet2 = nums2.ToHashSet();

        return new List<IList<int>>
        {
            hashSet1.Except(hashSet2).ToList(),
            hashSet2.Except(hashSet1).ToList()
        };
    }
}