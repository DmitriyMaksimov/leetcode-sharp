namespace leetcode_sharp;

// 3572. Maximize Y‑Sum by Picking a Triplet of Distinct X‑Values
// https://leetcode.com/problems/maximize-ysum-by-picking-a-triplet-of-distinct-xvalues
public class S03572
{
    public int MaxSumDistinctTriplet(int[] x, int[] y)
    {
        var map = new Dictionary<int, int>(x.Length);

        // Build map with max y per unique x
        for (var i = 0; i < x.Length; i++)
        {
            map[x[i]] = Math.Max(map.GetValueOrDefault(x[i]), y[i]);
        }

        // Find top 3 max values without sorting everything
        var first = int.MinValue;
        var second = int.MinValue;
        var third = int.MinValue;

        foreach (var val in map.Values)
        {
            if (val > first)
            {
                third = second;
                second = first;
                first = val;
            }
            else if (val > second)
            {
                third = second;
                second = val;
            }
            else if (val > third)
            {
                third = val;
            }
        }

        return map.Count < 3 ? -1 : first + second + third;
    }
}
