namespace leetcode_sharp;

// 4. Median of Two Sorted Arrays
// https://leetcode.com/problems/median-of-two-sorted-arrays/
public class S00004
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var combinedArray = new int[nums1.Length + nums2.Length];
        var index = 0;
        var index1 = 0;
        var index2 = 0;

        while (index < combinedArray.Length)
        {
            var n = 0;
            if (index1 == nums1.Length)
            {
                n = nums2[index2++];
            }
            else if (index2 == nums2.Length)
            {
                n = nums1[index1++];
            }
            else if (nums1[index1] < nums2[index2])
            {
                n = nums1[index1++];
            }
            else
            {
                n = nums2[index2++];
            }

            combinedArray[index++] = n;
        }

        var mid = combinedArray.Length / 2;

        return combinedArray.Length % 2 == 0 ? (combinedArray[mid - 1] + combinedArray[mid]) / 2.0 : combinedArray[mid];
    }
}