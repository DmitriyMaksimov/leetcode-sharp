namespace leetcode_sharp;

// 2001. Number of Pairs of Interchangeable Rectangles
// https://leetcode.com/problems/number-of-pairs-of-interchangeable-rectangles
public class S02001
{
    public long InterchangeableRectangles(int[][] rectangles)
    {
        var result = 0L;
        var mp = new Dictionary<double, int>();

        foreach (var rect in rectangles)
        {
            var ratio = (double)rect[0] / rect[1];

            if (mp.TryGetValue(ratio, out var value))
            {
                result += value;
            }

            mp[ratio] = mp.GetValueOrDefault(ratio) + 1;
        }

        return result;
    }
}
