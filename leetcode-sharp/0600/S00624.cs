namespace leetcode_sharp;

// 624. Maximum Distance in Arrays
// https://leetcode.com/problems/maximum-distance-in-arrays
public class S00624
{
    public int MaxDistance(IList<IList<int>> arrays)
    {
        var result = int.MinValue;
        var max = arrays[0][arrays[0].Count - 1];
        var min = arrays[0][0];

        for (var i = 1; i < arrays.Count; i++)
        {
            result = Math.Max(result, Math.Abs(arrays[i][0] - max));
            result = Math.Max(result, Math.Abs(arrays[i][arrays[i].Count - 1] - min));
            max = Math.Max(max, arrays[i][arrays[i].Count - 1]);
            min = Math.Min(min, arrays[i][0]);
        }

        return result;
    }
}
