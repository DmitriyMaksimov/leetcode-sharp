namespace leetcode_sharp;

// 2127. Maximum Employees to Be Invited to a Meeting
// https://leetcode.com/problems/maximum-employees-to-be-invited-to-a-meeting
public class S02127
{
    public int MaximumInvitations(int[] favorite)
    {
        var n = favorite.Length;
        var visited = new bool[n];

        var indegrees = new int[n];
        for (var i = 0; i < n; ++i)
        {
            ++indegrees[favorite[i]];
        }

        var queue = new Queue<int>();

        for (var i = 0; i < n; ++i)
        {
            if (indegrees[i] == 0)
            {
                visited[i] = true;
                queue.Enqueue(i);
            }
        }

        var dp = new int[n];
        while (queue.Count > 0)
        {
            var i = queue.Dequeue();
            var j = favorite[i];
            dp[j] = Math.Max(dp[j], dp[i] + 1);

            if (--indegrees[j] == 0)
            {
                visited[j] = true;
                queue.Enqueue(j);
            }
        }

        var result = 0;
        var result2 = 0;

        for (var i = 0; i < n; ++i)
        {
            if (!visited[i])
            {
                var length = 0;
                for (var j = i; !visited[j]; j = favorite[j])
                {
                    visited[j] = true;
                    ++length;
                }

                if (length == 2)
                {
                    result2 += 2 + dp[i] + dp[favorite[i]];
                }
                else
                {
                    result = Math.Max(result, length);
                }
            }
        }

        return Math.Max(result, result2);
    }
}
