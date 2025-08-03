namespace leetcode_sharp;

// 1424. Diagonal Traverse II
// https://leetcode.com/problems/diagonal-traverse-ii
public class S01424
{
    public int[] FindDiagonalOrder(IList<IList<int>> nums)
    {
        var result = new List<int>();
        var dict = new Dictionary<int, List<int>>();
        
        for (var i = 0; i < nums.Count; i++)
        {
            for (var j = 0; j < nums[i].Count; j++)
            {
                dict.TryAdd(i + j, []);
                dict[i + j].Add(nums[i][j]);
            }
        }

        var k = 0;

        while (dict.ContainsKey(k))
        {
            var cur = dict[k];
            cur.Reverse();
            result.AddRange(cur);
            k++;
        }

        return result.ToArray();
    }
}