namespace leetcode_sharp;

// 3206. Alternating Groups I
// https://leetcode.com/problems/alternating-groups-i
public class S03206
{
    public int NumberOfAlternatingGroups(int[] colors)
    {
        var result = 0;

        for (var i = 0; i < colors.Length; i++)
        {
            var prevColor = colors[(i - 1 + colors.Length) % colors.Length];
            var nextColor = colors[(i + 1) % colors.Length];

            if (colors[i] != prevColor && colors[i] != nextColor)
            {
                ++result;
            }
        }

        return result;
    }
}