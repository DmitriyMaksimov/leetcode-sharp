using System.Runtime.InteropServices;

namespace leetcode_sharp;

// 3783. Mirror Distance of an Integer
// https://leetcode.com/problems/mirror-distance-of-an-integer
public class S03783
{
    public int MirrorDistance(int n)
    {
        return Math.Abs(n - Reverse(n));
    }

    private static int Reverse(int n)
    {
        var reverse = 0;

        while (n > 0)
        {
            reverse = reverse * 10 + n % 10;
            n /= 10;
        }
        
        return reverse;
    }
}