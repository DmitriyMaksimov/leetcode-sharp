namespace leetcode_sharp;

// 3551. Minimum Swaps to Sort by Digit Sum
// https://leetcode.com/problems/minimum-swaps-to-sort-by-digit-sum
public class S03551
{
    public int MinSwaps(int[] nums)
    {
        var n = nums.Length;
        var values = new List<((int sum, int value), int index)>();

        for (var i = 0; i < n; i++)
        {
            var sum = DigitSum(nums[i]);
            values.Add(((sum, nums[i]), i));
        }

        values.Sort();

        var swaps = 0;
        var visited = new bool[n];

        for (var i = 0; i < n; i++)
        {
            if (visited[i] || values[i].index == i)
            {
                continue;
            }

            var cycleSize = 0;
            var j = i;

            while (!visited[j])
            {
                visited[j] = true;
                cycleSize++;
                j = values[j].index;
            }

            if (cycleSize > 1)
            {
                swaps += cycleSize - 1;
            }
        }

        return swaps;
    }

    private static int DigitSum(int n)
    {
        var sum = 0;

        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }

        return sum;
    }
}
