namespace leetcode_sharp;

// 1552. Magnetic Force Between Two Balls
// https://leetcode.com/problems/magnetic-force-between-two-balls
public class S01552
{
    public int MaxDistance(int[] position, int m)
    {
        Array.Sort(position);

        var left = 1;
        var right = position[^1] - position[0];
        var answer = -1;
        
        while (left <= right)
        {
            var mid = left + (right - left) / 2;
            var lastPosition = position[0];
            var balls = 1;

            for (var i = 1; i < position.Length; i++)
            {
                if (position[i] - lastPosition >= mid)
                {
                    lastPosition = position[i];
                    balls++;
                }
            }

            if (balls >= m)
            {
                answer = mid;
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return answer;
    }
}