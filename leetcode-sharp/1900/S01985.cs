namespace leetcode_sharp;

// 1985. Find the Kth Largest Integer in the Array
// https://leetcode.com/problems/find-the-kth-largest-integer-in-the-array
public class S01985
{
    public string KthLargestNumber(string[] nums, int k)
    {
        Array.Sort(nums, (a, b) => a.Length != b.Length ? a.Length.CompareTo(b.Length) : string.CompareOrdinal(a, b));

        return nums[^k];
    }
}