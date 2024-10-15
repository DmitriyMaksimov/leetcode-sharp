namespace leetcode_sharp;

// 1738. Find Kth Largest XOR Coordinate Value
// https://leetcode.com/problems/find-kth-largest-xor-coordinate-value
public class S01738
{
    public int KthLargestValue(int[][] matrix, int k)
    {
        var m = matrix.Length;
        var n = matrix[0].Length;
        var dp = new int[m][];

        var pq = new PriorityQueue<int, int>();

        for (var i = 0; i < m; ++i)
        {
            dp[i] = new int[n];

            for (var j = 0; j < n; ++j)
            {
                var x = i - 1 < 0 ? 0 : dp[i - 1][j];
                var y = j - 1 < 0 ? 0 : dp[i][j - 1];
                var z = i - 1 < 0 || j - 1 < 0 ? 0 : dp[i - 1][j - 1];

                dp[i][j] = x ^ y ^ z ^ matrix[i][j];

                pq.Enqueue(dp[i][j], dp[i][j]);

                if (pq.Count > k)
                {
                    pq.Dequeue();
                }
            }
        }

        return pq.Dequeue();
    }
}
