namespace leetcode_sharp;

// 1675. Minimize Deviation in Array
// https://leetcode.com/problems/minimize-deviation-in-array/
public class S01675
{
    public int MinimumDeviation(int[] nums)
    {
        var maxQueue = new PriorityQueue<int, int>();
        var minQueue = new PriorityQueue<int, int>();
        
        foreach (var it in nums)
        {
            var newValue = it % 2 != 0 ? it * 2 : it;
            maxQueue.Enqueue(newValue, int.MaxValue - newValue);
            minQueue.Enqueue(newValue, newValue);
        }

        var max = maxQueue.Dequeue();
        var result = max - minQueue.Peek();
        while (max % 2 == 0)
        {
            max /= 2;
            maxQueue.Enqueue(max, Int32.MaxValue - max);
            minQueue.Enqueue(max, max);
            max = maxQueue.Dequeue();
            result = Math.Min(result, max - minQueue.Peek());
        }

        return result;
    }
}
