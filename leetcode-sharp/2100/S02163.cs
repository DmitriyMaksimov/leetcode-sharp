namespace leetcode_sharp;

// 2163. Minimum Difference in Sums After Removal of Elements
// https://leetcode.com/problems/minimum-difference-in-sums-after-removal-of-elements
public class S02163
{
    public long MinimumDifference(int[] nums)
    {
        var n = nums.Length;
        var k = n / 3;
        var leftMins = new long[n];
        var rightMaxs = new long[n];
        var leftSum = 0L;
        var rightSum = 0L;
        var minDiff = long.MaxValue;

        var maxLeftHeap = new PriorityQueue<int, int>();
        for (var i = 0; i < k; i++)
        {
            maxLeftHeap.Enqueue(nums[i], -nums[i]);
            leftSum += nums[i];
        }

        leftMins[k - 1] = leftSum;

        for (var i = k; i < n - k; i++)
        {
            var x = nums[i];
            maxLeftHeap.TryPeek(out var top, out _);
            if (x < top)
            {
                maxLeftHeap.TryDequeue(out var removed, out _);
                leftSum -= removed;
                leftSum += x;
                maxLeftHeap.Enqueue(x, -x);
            }

            leftMins[i] = leftSum;
        }

        var minRightHeap = new PriorityQueue<int, int>();
        for (var i = n - 1; i >= n - k; i--)
        {
            minRightHeap.Enqueue(nums[i], nums[i]);
            rightSum += nums[i];
        }

        rightMaxs[n - k] = rightSum;

        for (var i = n - k - 1; i >= k - 1; i--)
        {
            var x = nums[i];
            minRightHeap.TryPeek(out var top, out _);
            if (x > top)
            {
                minRightHeap.TryDequeue(out var removed, out _);
                rightSum -= removed;
                rightSum += x;
                minRightHeap.Enqueue(x, x);
            }

            rightMaxs[i] = rightSum;
        }

        for (var i = k - 1; i < n - k; i++)
        {
            minDiff = Math.Min(minDiff, leftMins[i] - rightMaxs[i + 1]);
        }

        return minDiff;
    }
}