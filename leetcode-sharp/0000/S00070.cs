namespace leetcode_sharp;

// 70. Climbing Stairs
// https://leetcode.com/problems/climbing-stairs/
public class S00070
{
    public int ClimbStairs(int n)
    {
        if (n == 0) return 0;

        var prev = 0;
        var next = 1;
        for (var i = 1; i <= n; i++)
        {
            var sum = prev + next;
            prev = next;
            next = sum;
        }

        return next;
    }
}