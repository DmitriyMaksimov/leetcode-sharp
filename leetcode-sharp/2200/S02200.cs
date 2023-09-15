namespace leetcode_sharp;

// 2200. Find All K-Distant Indices in an Array
// https://leetcode.com/problems/find-all-k-distant-indices-in-an-array/
public class S02200
{
    public IList<int> FindKDistantIndices(int[] nums, int key, int k)
    {
        var res = new List<int>();
        for (int i = 0, j = 0; i < nums.Length; ++i)
        {
            if (nums[i] != key) continue;

            for (j = Math.Max(j, i - k); j <= i + k && j < nums.Length; ++j)
            {
                res.Add(j);
            }
        }

        return res;
    }
}