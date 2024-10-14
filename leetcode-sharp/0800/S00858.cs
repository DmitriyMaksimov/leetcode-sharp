namespace leetcode_sharp;

// 858. Mirror Reflection
// https://leetcode.com/problems/mirror-reflection
public class S00858
{
    public int MirrorReflection(int p, int q)
    {
        var m = 1;
        var n = 1;

        while (m * p != n * q)
        {
            n++;
            m = n * q / p;
        }

        return (m % 2, n % 2) switch
        {
            (0, 1) => 0,
            (1, 1) => 1,
            (1, 0) => 2,
            _ => -1
        };
    }
}
