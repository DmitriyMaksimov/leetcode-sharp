namespace leetcode_sharp;

// 2943. Maximize Area of Square Hole in Grid
// https://leetcode.com/problems/maximize-area-of-square-hole-in-grid
public class S02943
{
    public int MaximizeSquareHoleArea(int n, int m, int[] hBars, int[] vBars)
    {
        var hMaxGap = FindLongestConsecutive(hBars) + 1;
        var vMaxGap = FindLongestConsecutive(vBars) + 1;

        var side = Math.Min(hMaxGap, vMaxGap);

        return side * side;
    }

    private static int FindLongestConsecutive(int[] bars)
    {
        if (bars.Length == 0)
        {
            return 0;
        }

        Array.Sort(bars);
        var longest = 1;
        var current = 1;

        for (var i = 1; i < bars.Length; i++)
        {
            if (bars[i] == bars[i - 1] + 1)
            {
                current++;
                longest = Math.Max(longest, current);
            }
            else
            {
                current = 1;
            }
        }

        return longest;
    }
}