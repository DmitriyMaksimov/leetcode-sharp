namespace leetcode_sharp;

// 1863. Sum of All Subset XOR Totals
// https://leetcode.com/problems/sum-of-all-subset-xor-totals/
public class S01863
{
    public int SubsetXORSum(int[] nums)
    {
        return getAns(nums, 0, 0);
    }

    private static int getAns(int[] arr, int i, int cur)
    {
        if (i == arr.Length)
        {
            return cur;
        }

        return getAns(arr, i + 1, cur ^ arr[i]) + getAns(arr, i + 1, cur);
    }
}