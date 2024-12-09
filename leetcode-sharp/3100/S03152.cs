namespace leetcode_sharp;

// 3152. Special Array II
// https://leetcode.com/problems/special-array-ii
public class S03152
{
    public bool[] IsArraySpecial(int[] nums, int[][] queries)
    {
        var result = new bool[queries.Length];
        var pre = new int[nums.Length];
        pre[0] = 1;

        for (var i = 1; i < nums.Length; i++)
        {
            if ((nums[i] % 2 == 0 && nums[i - 1] % 2 != 0) || (nums[i] % 2 != 0 && nums[i - 1] % 2 == 0))
            {
                pre[i] = pre[i - 1] + 1;
            }
            else
            {
                pre[i] = pre[i - 1];
            }
        }

        for (var i = 0; i < queries.Length; i++)
        {
            result[i] = queries[i][1] - queries[i][0] <= pre[queries[i][1]] - pre[queries[i][0]];
        }

        return result;
    }
}
