namespace leetcode_sharp;

// 835. Image Overlap
// https://leetcode.com/problems/image-overlap
public class S00835
{
    public int LargestOverlap(int[][] img1, int[][] img2)
    {
        var n = img1.Length;
        List<int> list1 = [];
        List<int> list2 = [];

        Dictionary<int, int> counts = [];

        for (var i = 0; i < n * n; ++i)
        {
            if (img1[i / n][i % n] == 1)
            {
                list1.Add(i / n * 100 + i % n);
            }
        }

        for (var i = 0; i < n * n; ++i)
        {
            if (img2[i / n][i % n] == 1)
            {
                list2.Add(i / n * 100 + i % n);
            }
        }

        foreach (var i in list1)
        {
            foreach (var j in list2)
            {
                counts[i - j] = counts.GetValueOrDefault(i - j) + 1;
            }
        }

        return counts.Values.Prepend(0).Max();
    }
}
