namespace leetcode_sharp;

// 3432. Count Partitions with Even Sum Difference
// https://leetcode.com/problems/count-partitions-with-even-sum-difference
public class S03432
{
    public int CountPartitions(int[] nums)
    {
        return nums.Sum() % 2 == 0 ? nums.Length - 1 : 0;
    }
}
