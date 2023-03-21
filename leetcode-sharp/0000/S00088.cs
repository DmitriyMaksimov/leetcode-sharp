namespace leetcode_sharp;

// 88. Merge Sorted Array
// https://leetcode.com/problems/merge-sorted-array/
public class S00088
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var currentIndex = m + n - 1;
        var index1 = m - 1;
        var index2 = n - 1;
        while (currentIndex >= 0 && index2 >= 0)
        {
            if (index1 >= 0 && nums1[index1] > nums2[index2])
            {
                nums1[currentIndex] = nums1[index1--];
            }
            else
            {
                nums1[currentIndex] = nums2[index2--];
            }
            --currentIndex;
        }
    }
}