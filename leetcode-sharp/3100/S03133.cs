namespace leetcode_sharp;

// 3133. Minimum Array End
// https://leetcode.com/problems/minimum-array-end
public class S03133
{
    public long MinEnd(int n, int x)
    {
        long res = x;

        for (long bx = 1, bn = 1; bn < n; bx <<= 1)
        {
            if ((bx & x) == 0)
            {
                if ((bn & (n - 1)) != 0)
                {
                    res += bx;
                }

                bn <<= 1;
            }
        }

        return res;
    }
}