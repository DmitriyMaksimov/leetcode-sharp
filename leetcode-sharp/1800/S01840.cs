namespace leetcode_sharp;

// 1840. Maximum Building Height
// https://leetcode.com/problems/maximum-building-height
public class S01840
{
    public int MaxBuilding(int n, int[][] restrictions)
    {
        var arr = new List<int[]>(restrictions);

        arr.Add([1, 0]);
        arr.Add([n, n - 1]);

        arr.Sort((a, b) => a[0].CompareTo(b[0]));

        var m = arr.Count;

        for (var i = 1; i < m; i++)
        {
            arr[i][1] = Math.Min(arr[i][1], arr[i - 1][1] + arr[i][0] - arr[i - 1][0]);
        }

        for (var i = m - 2; i >= 0; i--)
        {
            arr[i][1] = Math.Min(arr[i][1], arr[i + 1][1] + arr[i + 1][0] - arr[i][0]);
        }

        var result = 0;

        for (var i = 1; i < m; i++)
        {
            var l = arr[i - 1][0];
            var h1 = arr[i - 1][1];
            var r = arr[i][0];
            var h2 = arr[i][1];

            var peak = Math.Max(h1, h2) + (r - l - Math.Abs(h1 - h2)) / 2;
            result = Math.Max(result, peak);
        }

        return result;
    }
}