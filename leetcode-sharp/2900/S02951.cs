namespace leetcode_sharp;

// 2951. Find the Peaks
// https://leetcode.com/problems/find-the-peaks
public class S02951
{
    public IList<int> FindPeaks(int[] mountain)
    {
        var peaks = new List<int>();
        var n = mountain.Length;

        for (var i = 1; i < n - 1; i++)
        {
            if (mountain[i] > mountain[i - 1] && mountain[i] > mountain[i + 1])
            {
                peaks.Add(i);
            }
        }

        return peaks;
    }
}