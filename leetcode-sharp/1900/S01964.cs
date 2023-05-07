namespace leetcode_sharp;

// 1964. Find the Longest Valid Obstacle Course at Each Position
// https://leetcode.com/problems/find-the-longest-valid-obstacle-course-at-each-position/
public class S01964
{
    public int[] LongestObstacleCourseAtEachPosition(int[] obstacles)
    {
        var n = obstacles.Length;
        var length = 0;
        var result = new int[n];
        var dp = new int[n];

        for (var i = 0; i < n; ++i)
        {
            var left = 0;
            var right = length;
            
            while (left < right)
            {
                var m = (left + right) / 2;
                if (dp[m] <= obstacles[i])
                {
                    left = m + 1;
                }
                else
                {
                    right = m;
                }
            }

            result[i] = left + 1;

            if (length == left)
            {
                length++;
            }

            dp[left] = obstacles[i];
        }

        return result;
    }
}