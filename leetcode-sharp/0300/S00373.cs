﻿namespace leetcode_sharp;

// 373. Find K Pairs with Smallest Sums
// https://leetcode.com/problems/find-k-pairs-with-smallest-sums/
public class S00373
{
    public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k)
    {
        var result = new List<IList<int>>();
        var priorityQueue = new PriorityQueue<(int sum, int position), int>();

        // Enqueue all elements from num1 and first element from num2 to the queue
        foreach (var x in nums1)
        {
            var sum = x + nums2[0];
            priorityQueue.Enqueue((sum, 0), sum);
        }

        while (k-- > 0 && priorityQueue.Count > 0)
        {
            var (sum, pos) = priorityQueue.Dequeue();

            result.Add(new List<int> {sum - nums2[pos], nums2[pos]});

            // If we have elements in num2 left, let's top up the queue
            if (pos + 1 < nums2.Length)
            {
                var s1 = sum - nums2[pos] + nums2[pos + 1];
                priorityQueue.Enqueue((s1, pos + 1), s1);
            }
        }

        return result;
    }
}