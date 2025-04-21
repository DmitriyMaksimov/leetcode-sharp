namespace leetcode_sharp;

// 2145. Count the Hidden Sequences
// https://leetcode.com/problems/count-the-hidden-sequences
public class S02145
{
    public int NumberOfArrays(int[] differences, int lower, int upper)
    {
        var sum = 0L;
        var minSum = 0L;
        var maxSum = 0L;

        foreach (var diff in differences)
        {
            sum += diff;
            minSum = Math.Min(minSum, sum);
            maxSum = Math.Max(maxSum, sum);
        }

        return (int)Math.Max(0, (upper - lower) - (maxSum - minSum) + 1);
    }
}
