namespace leetcode_sharp;

// 2078. Two Furthest Houses With Different Colors
// https://leetcode.com/problems/two-furthest-houses-with-different-colors/
public class S02078
{
    public int MaxDistance(int[] colors)
    {
        var n = colors.Length;
        var i = 0;
        var j = n - 1;

        while (colors[0] == colors[j])
        {
            j--;
        }

        while (colors[n - 1] == colors[i])
        {
            i++;
        }

        return Math.Max(n - 1 - i, j);
    }
}