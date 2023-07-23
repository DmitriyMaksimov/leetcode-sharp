namespace leetcode_sharp;

// 735. Asteroid Collision
// https://leetcode.com/problems/asteroid-collision/
public class S00735
{
    public int[] AsteroidCollision(int[] asteroids)
    {
        var n = asteroids.Length;
        var stack = new Stack<int>();

        for (var i = 0; i < n; i++)
        {
            if (!stack.Any() || asteroids[i] > 0)
            {
                stack.Push(asteroids[i]);
            }
            else
            {
                while (stack.Any() && stack.Peek() > 0 && stack.Peek() < Math.Abs(asteroids[i]))
                {
                    stack.Pop();
                }

                if (stack.Any() && stack.Peek() == Math.Abs(asteroids[i]))
                {
                    stack.Pop();
                }
                else
                {
                    if (!stack.Any() || stack.Peek() < 0)
                    {
                        stack.Push(asteroids[i]);
                    }
                }
            }
        }

        var ans = new int[stack.Count];
        var size = stack.Count;
        while (stack.Any())
        {
            ans[--size] = stack.Pop();
        }

        return ans;
    }
}