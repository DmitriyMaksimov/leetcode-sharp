namespace leetcode_sharp;

// 3532. Path Existence Queries in a Graph I
// https://leetcode.com/problems/path-existence-queries-in-a-graph-i
public class S03532
{
    public bool[] PathExistenceQueries(int n, int[] nums, int maxDiff, int[][] queries)
    {
        var cuts = new List<int> { 0 };

        for (var i = 1; i < n; ++i)
        {
            if (nums[i] - nums[i - 1] > maxDiff)
            {
                cuts.Add(i);
            }
        }

        var result = new bool[queries.Length];

        for (var i = 0; i < queries.Length; ++i)
        {
            var u = BinarySearch(cuts, queries[i][0] + 1);
            var v = BinarySearch(cuts, queries[i][1] + 1);
            result[i] = u == v;
        }

        return result;
    }

    private static int BinarySearch(List<int> list, int value)
    {
        var index = list.BinarySearch(value);
        return index < 0 ? ~index : index;
    }
}
