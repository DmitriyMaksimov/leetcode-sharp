namespace leetcode_sharp;

// 905. Sort Array By Parity
// https://leetcode.com/problems/sort-array-by-parity/
public class S00905
{
    public int[] SortArrayByParity(int[] nums)
    {
        var result = new int[nums.Length];
        var evenIndex = 0;
        var oddIndex = nums.Length - 1;
        foreach (var num in nums)
        {
            if (num % 2 == 0)
            {
                result[evenIndex++] = num;
            }
            else
            {
                result[oddIndex--] = num;
            }
        }

        return result;
    }
}