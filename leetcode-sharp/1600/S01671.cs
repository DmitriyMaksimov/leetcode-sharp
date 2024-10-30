namespace leetcode_sharp;

// 1671. Minimum Number of Removals to Make Mountain Array
// https://leetcode.com/problems/minimum-number-of-removals-to-make-mountain-array
public class S01671
{
    public int MinimumMountainRemovals(int[] nums)
    {
        var n = nums.Length;
        var leftLis = new int[n];
        var rightLis = new int[n];
        List<int> v = [];

        // Forward pass
        for (var i = 0; i < n; ++i)
        {
            var x = nums[i];
            var index = v.BinarySearch(x);
            if (index < 0)
            {
                index = ~index;
            }

            leftLis[i] = index;

            if (index < v.Count)
            {
                v[index] = x;
            }
            else
            {
                v.Add(x);
            }
        }

        v.Clear();

        // Backward pass
        for (var i = n - 1; i >= 0; --i)
        {
            var x = nums[i];
            var index = v.BinarySearch(x);
            if (index < 0)
            {
                index = ~index;
            }

            rightLis[i] = index;

            if (index < v.Count)
            {
                v[index] = x;
            }
            else
            {
                v.Add(x);
            }
        }

        var result = n;

        for (var i = 1; i < n - 1; ++i)
        {
            if (leftLis[i] > 0 && rightLis[i] > 0)
            {
                result = Math.Min(result, n - (leftLis[i] + rightLis[i] + 1));
            }
        }

        return result;
    }
}
