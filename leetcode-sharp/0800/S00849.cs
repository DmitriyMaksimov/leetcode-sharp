namespace leetcode_sharp;

// 849. Maximize Distance to Closest Person
// https://leetcode.com/problems/maximize-distance-to-closest-person
public class S00849
{
    public int MaxDistToClosest(int[] seats)
    {
        var left = -1;
        var result = 0;

        for (int i = 0; i < seats.Length; i++)
        {
            if (seats[i] == 0)
            {
                continue;
            }

            result = left == -1 ? Math.Max(result, i) : Math.Max(result, (i - left) / 2);

            left = i;
        }

        if (seats[^1] == 0)
        {
            result = Math.Max(result, seats.Length - 1 - left);
        }

        return result;
    }
}
