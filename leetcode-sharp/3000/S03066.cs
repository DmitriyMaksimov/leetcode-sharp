namespace leetcode_sharp;

// 3066. Minimum Operations to Exceed Threshold Value II
// https://leetcode.com/problems/minimum-operations-to-exceed-threshold-value-ii
public class S03066
{
    public int MinOperations(int[] nums, int k)
    {
        var minHeap = new PriorityQueue<long, long>();
        foreach (var num in nums)
        {
            minHeap.Enqueue(num, num);
        }

        var result = 0;

        while (minHeap.Count > 0 && minHeap.Peek() < k)
        {
            if (minHeap.Count < 2)
            {
                return -1;
            }

            minHeap.TryDequeue(out var num1, out _);
            minHeap.TryDequeue(out var num2, out _);

            var newValue = 2 * num1 + num2;
            minHeap.Enqueue(newValue, newValue);
            result++;
        }

        return result;
    }
}
