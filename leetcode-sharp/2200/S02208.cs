namespace leetcode_sharp;

// 2208. Minimum Operations to Halve Array Sum
// https://leetcode.com/problems/minimum-operations-to-halve-array-sum
public class S02208
{
    public int HalveArray(int[] nums)
    {
        var maxHeap = new PriorityQueue<double, double>(Comparer<double>.Create((a, b) => b.CompareTo(a)));
        var half = nums.Sum(n => (double)n) / 2;

        foreach (var n in nums)
        {
            maxHeap.Enqueue(n, n);
        }

        var result = 0;

        while (half > 0)
        {
            var largest = maxHeap.Dequeue();
            var halved = largest / 2;
            half -= halved;
            maxHeap.Enqueue(halved, halved);
            result++;
        }

        return result;
    }
}
