namespace leetcode_sharp;

// 3208. Alternating Groups II
// https://leetcode.com/problems/alternating-groups-ii
public class S03208
{
    public int NumberOfAlternatingGroups(int[] colors, int k)
    {
        var size = colors.Length;
        var start = 0;
        var end = 1;
        var bad = 0;
        var result = 0;

        while (start < size)
        {
            if (colors[end % size] == colors[(end - 1) % size])
            {
                bad++;
            }

            if (end - start + 1 == k)
            {
                if (bad == 0)
                {
                    result++;
                }

                start++;

                if (colors[start % size] == colors[(start - 1) % size])
                {
                    bad--;
                }
            }

            end++;
        }

        return result;
    }
}
