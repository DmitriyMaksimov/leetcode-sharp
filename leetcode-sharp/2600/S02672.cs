namespace leetcode_sharp;

// 2672. Number of Adjacent Elements With the Same Color
// https://leetcode.com/problems/number-of-adjacent-elements-with-the-same-color
public class S02672
{
    public int[] ColorTheArray(int n, int[][] queries)
    {
        var result = new List<int>();
        var nums = new int[n];
        var count = 0;

        foreach (var q in queries)
        {
            var i = q[0];
            var val = q[1];

            if (nums[i] != 0 && i - 1 >= 0 && nums[i - 1] == nums[i])
            {
                count--;
            }

            if (nums[i] != 0 && i + 1 < n && nums[i + 1] == nums[i])
            {
                count--;
            }

            nums[i] = val;

            if (i - 1 >= 0 && nums[i - 1] == nums[i])
            {
                count++;
            }

            if (i + 1 < n && nums[i + 1] == nums[i])
            {
                count++;
            }

            result.Add(count);
        }

        return result.ToArray();
    }
}
