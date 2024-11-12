namespace leetcode_sharp;

// 2425. Bitwise XOR of All Pairings
// https://leetcode.com/problems/bitwise-xor-of-all-pairings
public class S02425
{
    public int XorAllNums(int[] nums1, int[] nums2)
    {
        var x = nums1.Aggregate(0, (current, a) => current ^ a);
        var y = nums2.Aggregate(0, (current, b) => current ^ b);

        return (nums1.Length % 2 * y) ^ (nums2.Length % 2 * x);
    }
}
