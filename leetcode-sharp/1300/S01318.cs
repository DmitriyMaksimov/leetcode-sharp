namespace leetcode_sharp;

// 1318. Minimum Flips to Make a OR b Equal to c
// https://leetcode.com/problems/minimum-flips-to-make-a-or-b-equal-to-c/
public class S01318
{
    public int MinFlips(int a, int b, int c)
    {
        var count = 0;

        while (a > 0 || b > 0 || c > 0)
        {
            if ((c & 1) == 0)
            {
                if ((a & 1) == 1)
                {
                    count++;
                }

                if ((b & 1) == 1)
                {
                    count++;
                }
            }
            else if ((a & 1) == 0 && (b & 1) == 0)
            {
                count++;
            }

            a >>= 1;
            b >>= 1;
            c >>= 1;
        }

        return count;
    }
}