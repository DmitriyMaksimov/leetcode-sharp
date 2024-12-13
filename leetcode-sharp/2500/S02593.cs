namespace leetcode_sharp;

// 2593. Find Score of an Array After Marking All Elements
// https://leetcode.com/problems/find-score-of-an-array-after-marking-all-elements
public class S02593
{
    public long FindScore(int[] nums)
    {
        var n = nums.Length;
        var sortedSet = new SortedSet<(long value, int index)>();
        var visited = new bool[n];

        for (var i = 0; i < nums.Length; i++)
        {
            sortedSet.Add((nums[i], i));
        }

        var result = 0L;

        foreach (var (value, index) in sortedSet)
        {
            if (visited[index])
            {
                continue;
            }

            result += value;
            visited[index] = true;

            if (index - 1 >= 0)
            {
                visited[index - 1] = true;
            }

            if (index + 1 < n)
            {
                visited[index + 1] = true;
            }
        }

        return result;
    }
}
