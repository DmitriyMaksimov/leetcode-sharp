namespace leetcode_sharp;

// 1792. Maximum Average Pass Ratio
// https://leetcode.com/problems/maximum-average-pass-ratio
public class S01792
{
    public double MaxAverageRatio(int[][] classes, int extraStudents)
    {
        var maxHeap = new PriorityQueue<(double Profit, double Pass, double Total), double>(Comparer<double>.Create((x, y) => y.CompareTo(x)));

        foreach (var c in classes)
        {
            double pass = c[0];
            double total = c[1];
            maxHeap.Enqueue((Profit(pass, total), pass, total), Profit(pass, total));
        }

        while (extraStudents-- > 0)
        {
            var (_, pass, total) = maxHeap.Dequeue();
            pass++;
            total++;
            maxHeap.Enqueue((Profit(pass, total), pass, total), Profit(pass, total));
        }

        var result = 0.0;
        while (maxHeap.Count > 0)
        {
            var (_, pass, total) = maxHeap.Dequeue();
            result += pass / total;
        }

        return result / classes.Length;
    }

    private static double Profit(double pass, double total)
    {
        return (pass + 1) / (total + 1) - pass / total;
    }
}
