namespace leetcode_sharp;

// 2103. Rings and Rods
// https://leetcode.com/problems/rings-and-rods/
public class S02103
{
    public int CountPoints(string rings)
    {
        var values = new bool[10, 3];

        for (var i = 0; i < rings.Length;)
        {
            var color = rings[i++];
            var ring = rings[i++] - '0';
            values[ring, colorToIndex(color)] = true;
        }

        var count = 0;
        for (var i = 0; i < values.GetLength(0); i++)
        {
            if (values[i, 0] && values[i, 1] && values[i, 2])
            {
                count++;
            }
        }

        return count;
    }

    private static int colorToIndex(char ch)
    {
        return ch switch
        {
            'R' => 0,
            'B' => 1,
            _ => 2
        };
    }
}