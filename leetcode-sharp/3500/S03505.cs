namespace leetcode_sharp;

// 3505. Minimum Operations to Make Elements Within K Subarrays Equal
// https://leetcode.com/problems/minimum-operations-to-make-elements-within-k-subarrays-equal
public class S03505
{
    public long MinOperations(int[] nums, int x, int k)
    {
        var n = nums.Length;
        var left = new PriorityQueue<int, int>();
        var right = new PriorityQueue<int, int>();
        var delayed = new Dictionary<int, int>();
        var leftSize = 0;
        var rightSize = 0;
        var sumLeft = 0L;
        var sumRight = 0L;
        var ops = new long[n];

        for (var i = 0; i < n; ++i)
        {
            var num = nums[i];
            if (left.Count == 0 || num <= left.Peek())
            {
                left.Enqueue(num, -num);
                ++leftSize;
                sumLeft += num;
            }
            else
            {
                right.Enqueue(num, num);
                ++rightSize;
                sumRight += num;
            }

            Balance();
            if (i >= x)
            {
                num = nums[i - x];
                delayed.TryGetValue(num, out var count);
                delayed[num] = count + 1;
                if (num <= left.Peek())
                {
                    --leftSize;
                    sumLeft -= num;
                    if (num == left.Peek())
                    {
                        Prune(left);
                    }
                }
                else
                {
                    --rightSize;
                    sumRight -= num;
                    if (num == right.Peek())
                    {
                        Prune(right);
                    }
                }

                Balance();
            }

            if (i >= x - 1)
            {
                long mid = left.Peek();
                ops[i] = sumRight - sumLeft + mid * (leftSize - rightSize);
            }
        }

        var dp = new long[n, k + 1];
        for (var i = 0; i < n; ++i)
        {
            for (var j = 1; j <= k; ++j)
            {
                dp[i, j] = long.MaxValue;
            }
        }

        for (var j = 1; j <= k; ++j)
        {
            if (j == 1)
            {
                dp[x - 1, j] = ops[x - 1];
            }
            else
            {
                dp[j * x - 1, j] = dp[(j - 1) * x - 1, j - 1] + ops[j * x - 1];
            }
        }

        for (var j = 1; j <= k; ++j)
        {
            for (var i = j * x; i < n; ++i)
            {
                dp[i, j] = Math.Min(dp[i - x, j - 1] + ops[i], dp[i - 1, j]);
            }
        }

        return dp[n - 1, k];

        void Prune(PriorityQueue<int, int> heap)
        {
            while (heap.Count > 0 && delayed.TryGetValue(heap.Peek(), out var count) && count > 0)
            {
                var num = heap.Dequeue();
                delayed[num] = count - 1;
            }
        }

        void Balance()
        {
            if (leftSize > rightSize + 1)
            {
                var num = left.Dequeue();
                right.Enqueue(num, num);
                sumRight += num;
                sumLeft -= num;
                ++rightSize;
                --leftSize;
                Prune(left);
            }
            else if (rightSize > leftSize)
            {
                var num = right.Dequeue();
                left.Enqueue(num, -num);
                sumLeft += num;
                sumRight -= num;
                ++leftSize;
                --rightSize;
                Prune(right);
            }
        }
    }
}
