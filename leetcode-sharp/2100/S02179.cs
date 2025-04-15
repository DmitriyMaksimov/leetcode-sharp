namespace leetcode_sharp;

// 2179. Count Good Triplets in an Array
// https://leetcode.com/problems/count-good-triplets-in-an-array
public class S02179
{
    public long GoodTriplets(int[] nums1, int[] nums2)
    {
        Dictionary<int, int> idxNums2 = [];

        for (var i = 0; i < nums2.Length; i++)
        {
            idxNums2[nums2[i]] = i;
        }

        var nums = new int[nums2.Length];
        for (var i = 0; i < nums2.Length; i++)
        {
            nums[i] = idxNums2[nums1[i]];
        }

        var smaller = CountSmallerLeft(nums);
        var greater = CountGreaterRight(nums);
        var result = 0L;

        for (var i = 1; i < nums2.Length; i++)
        {
            result += (long)smaller[i] * greater[i];
        }

        return result;
    }

    private static int[] CountSmallerLeft(int[] nums)
    {
        var output = new int[nums.Length];
        List<int> sortedList = [];

        for (var i = 0; i < nums.Length; i++)
        {
            var idx = sortedList.BinarySearch(nums[i]);
            if (idx < 0)
            {
                idx = ~idx;
            }

            output[i] = idx;
            sortedList.Insert(idx, nums[i]);
        }

        return output;
    }

    private static int[] CountGreaterRight(int[] nums)
    {
        var output = new int[nums.Length];
        List<int> sortedList = [];

        for (var i = nums.Length - 1; i >= 0; i--)
        {
            var idx = sortedList.BinarySearch(nums[i]);
            if (idx < 0)
            {
                idx = ~idx;
            }

            output[i] = sortedList.Count - idx;
            sortedList.Insert(idx, nums[i]);
        }

        return output;
    }
}
