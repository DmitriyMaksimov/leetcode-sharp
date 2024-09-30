namespace leetcode_sharp;

// 1247. Minimum Swaps to Make Strings Equal
// https://leetcode.com/problems/minimum-swaps-to-make-strings-equal
public class S01247
{
    public int MinimumSwap(string s1, string s2)
    {
        var x1 = 0;
        var y1 = 0;
        var x2 = 0;
        var y2 = 0;

        for (var i = 0; i < s1.Length; i++)
        {
            var c1 = s1[i];
            var c2 = s2[i];

            if (c1 == c2)
            {
                continue;
            }

            if (c1 == 'x')
            {
                x1++;
            }
            else
            {
                y1++;
            }

            if (c2 == 'x')
            {
                x2++;
            }
            else
            {
                y2++;
            }
        }

        if ((x1 + x2) % 2 != 0 || (y1 + y2) % 2 != 0)
        {
            return -1;
        }

        return x1 / 2 + y1 / 2 + x1 % 2 * 2;
    }
}
