namespace leetcode_sharp;

// 3712. Sum of Elements With Frequency Divisible by K
// https://leetcode.com/problems/sum-of-elements-with-frequency-divisible-by-k
public class S03712
{
    public int SumDivisibleByK(int[] nums, int k)
    {
        var frequencies = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            frequencies[num] = frequencies.GetValueOrDefault(num) + 1;
        }

        return frequencies
            .Where(x => x.Value % k == 0)
            .Aggregate(0, (current, frequency) => current + frequency.Key * frequency.Value);
    }
}