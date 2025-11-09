namespace leetcode_sharp;

// 3688. Bitwise OR of Even Numbers in an Array
// https://leetcode.com/problems/bitwise-or-of-even-numbers-in-an-array
public class S03688
{
    public int EvenNumberBitwiseORs(int[] nums)
    {
        return nums.Aggregate(0, (result, n) => n % 2 == 0 ? result | n : result);
    }
}