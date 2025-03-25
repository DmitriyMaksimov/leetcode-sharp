namespace leetcode_sharp;

// 3394. Check if Grid can be Cut into Sections
// https://leetcode.com/problems/check-if-grid-can-be-cut-into-sections
public class S03394
{
    public bool CheckValidCuts(int n, int[][] rectangles)
    {
        var vertical = new List<List<int>>();
        var horizontal = new List<List<int>>();

        foreach (var rect in rectangles)
        {
            vertical.Add([rect[1], rect[3]]);
            horizontal.Add([rect[0], rect[2]]);
        }

        List<List<int>> mergedH = MergeIntervals(horizontal);
        List<List<int>> mergedV = MergeIntervals(vertical);

        return mergedH.Count >= 3 || mergedV.Count >= 3;
    }

    private static List<List<int>> MergeIntervals(List<List<int>> intervals)
    {
        if (intervals.Count <= 1)
        {
            return intervals;
        }

        intervals.Sort((a, b) => a[0].CompareTo(b[0]));

        var merged = new List<List<int>>();
        merged.Add([..intervals[0]]);

        for (var i = 1; i < intervals.Count; i++)
        {
            if (intervals[i][0] < merged[^1][1])
            {
                merged[^1][1] = Math.Max(merged[^1][1], intervals[i][1]);
            }
            else
            {
                merged.Add([..intervals[i]]);
            }
        }

        return merged;
    }
}
