namespace leetcode_sharp;

// 3162. Find the Number of Good Pairs I
// https://leetcode.com/problems/find-the-number-of-good-pairs-i
public class S03162
{
    public int NumberOfPairs(int[] nums1, int[] nums2, int k)
    {
        return nums1.Sum(n1 => nums2.Count(n2 => n1 % (n2 * k) == 0));
    }
}