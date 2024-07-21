namespace leetcode_sharp;

// 3178. Find the Child Who Has the Ball After K Seconds
// https://leetcode.com/problems/find-the-child-who-has-the-ball-after-k-seconds
public class S03178
{
    public int NumberOfChild(int n, int time)
    {
        var turns = time / (n - 1);

        time %= n - 1;

        return turns % 2 == 0 ? time : n - time - 1;
    }
}