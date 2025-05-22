namespace leetcode_sharp;

// 3362. Zero Array Transformation III
// https://leetcode.com/problems/zero-array-transformation-iii
public class S03362
{
    public int MaxRemoval(int[] nums, int[][] queries)
    {
        Array.Sort(queries, (a, b) => a[0].CompareTo(b[0]));

        var available = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
        var assigned = new PriorityQueue<int, int>();

        var count = 0;
        var k = 0;

        for (var time = 0; time < nums.Length; time++)
        {
            // Remove expired assignments
            while (assigned.Count > 0 && assigned.Peek() < time)
            {
                assigned.Dequeue();
            }

            while (k < queries.Length && queries[k][0] <= time)
            {
                available.Enqueue(queries[k][1], queries[k][1]);
                k++;
            }

            while (assigned.Count < nums[time] && available.Count > 0 && available.Peek() >= time)
            {
                var deadline = available.Dequeue();
                assigned.Enqueue(deadline, deadline);
                count++;
            }

            if (assigned.Count < nums[time])
            {
                return -1;
            }
        }

        return queries.Length - count;
    }
}
