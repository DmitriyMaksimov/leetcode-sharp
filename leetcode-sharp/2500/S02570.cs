namespace leetcode_sharp;

// 2570. Merge Two 2D Arrays by Summing Values
// https://leetcode.com/problems/merge-two-2d-arrays-by-summing-values
public class S02570
{
    public int[][] MergeArrays(int[][] nums1, int[][] nums2)
    {
        var result = new List<int[]>();
        var p1 = 0;
        var p2 = 0;

        while (p1 < nums1.Length && p2 < nums2.Length)
        {
            if (nums1[p1][0] == nums2[p2][0])
            {
                result.Add(new[] {nums1[p1][0], nums1[p1++][1] + nums2[p2++][1]});
            }
            else if (nums1[p1][0] < nums2[p2][0])
            {
                result.Add(nums1[p1++]);
            }
            else
            {
                result.Add(nums2[p2++]);
            }
        }

        while (p1 < nums1.Length)
        {
            result.Add(nums1[p1++]);
        }

        while (p2 < nums2.Length)
        {
            result.Add(nums2[p2++]);
        }

        return result.ToArray();
    }
}