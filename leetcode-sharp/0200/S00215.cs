namespace leetcode_sharp;

// 215. Kth Largest Element in an Array
// https://leetcode.com/problems/kth-largest-element-in-an-array/
public class S00215
{
    public int FindKthLargest(int[] nums, int k)
    {
        var pq = new PriorityQueue<int, int>();

        foreach (var val in nums)
        {
            pq.Enqueue(val, val);

            if (pq.Count > k)
            {
                pq.Dequeue();
            }
        }

        return pq.Peek();
    }
}