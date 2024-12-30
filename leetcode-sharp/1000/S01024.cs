namespace leetcode_sharp;

// 1024. Video Stitching
// https://leetcode.com/problems/video-stitching
public class S01024
{
    public int VideoStitching(int[][] clips, int time)
    {
        Array.Sort(clips, (a, b) => a[0] - b[0]);

        var i = 0;
        var start = 0;
        var result = 0;

        while (start < time)
        {
            var maxEnd = 0;

            while (i < clips.Length && clips[i][0] <= start)
            {
                maxEnd = Math.Max(maxEnd, clips[i][1]);
                i++;
            }

            if (start == maxEnd)
            {
                return -1;
            }

            start = maxEnd;
            result++;
        }

        return result;
    }
}
