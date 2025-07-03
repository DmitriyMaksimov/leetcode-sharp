namespace leetcode_sharp;

// 3275. K-th Nearest Obstacle Queries
// https://leetcode.com/problems/k-th-nearest-obstacle-queries
public class S03275
{
    public int[] ResultsArray(int[][] queries, int k)
    {
        var n = queries.Length;
        var queue = new PriorityQueue<int, int>();
        var result = new int[n];

        for (var i = 0; i < n; i++)
        {
            var sum = Math.Abs(queries[i][0]) + Math.Abs(queries[i][1]);
            queue.Enqueue(sum, -sum);

            if (queue.Count > k)
            {
                queue.Dequeue();
            }

            result[i] = queue.Count == k ? queue.Peek() : -1;
        }

        return result;
    }
}