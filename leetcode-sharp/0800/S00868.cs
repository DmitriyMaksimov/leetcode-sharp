namespace leetcode_sharp;

// 868. Binary Gap
// https://leetcode.com/problems/binary-gap/
public class S00868
{
    public int BinaryGap(int n)
    {
        var max = 0;
        var last = -1;
        var i = 0;

        while (n > 0)
        {
            if ((n & 1) == 1)
            {
                if (last >= 0)
                {
                    max = Math.Max(max, i - last);
                }

                last = i;
            }

            n >>= 1;
            i++;
        }

        return max;
    }
}