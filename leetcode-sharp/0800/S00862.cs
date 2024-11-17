namespace leetcode_sharp;

// 862. Shortest Subarray with Sum at Least K
// https://leetcode.com/problems/shortest-subarray-with-sum-at-least-k
public class S00862
{
    public int ShortestSubarray(int[] nums, int k)
    {
        var n = nums.Length;

        var prefixSums = new long[n + 1];

        for (var i = 0; i < n; i++)
        {
            prefixSums[i + 1] = prefixSums[i] + nums[i];
        }

        var deque = new LinkedList<int>();

        var result = n + 1;

        for (var i = 0; i < n + 1; i++)
        {
            while (deque.Count > 0 && prefixSums[i] - prefixSums[deque.First!.Value] >= k)
            {
                result = Math.Min(result, i - deque.First.Value);
                deque.RemoveFirst();
            }

            while (deque.Count > 0 && prefixSums[i] <= prefixSums[deque.Last!.Value])
            {
                deque.RemoveLast();
            }

            deque.AddLast(i);
        }

        return result <= n ? result : -1;
    }
}
