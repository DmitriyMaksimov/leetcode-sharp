namespace leetcode_sharp;

// 3020. Find the Maximum Number of Elements in Subset
// https://leetcode.com/problems/find-the-maximum-number-of-elements-in-subset
public class S03020
{
    public int MaximumLength(int[] nums)
    {
        var frequency = new Dictionary<long, int>();

        foreach (var n in nums)
        {
            frequency[n] = frequency.GetValueOrDefault(n) + 1;
        }

        var result = 0L;

        foreach (var value in frequency.Keys.OrderBy(x => x).ToList())
        {
            var current = value;
            var count = 0L;

            if (current == 1)
            {
                count += frequency[current];
                frequency[current] = 0;
            }

            while (current <= int.MaxValue && frequency.TryGetValue(current, out var occurrences) && occurrences > 0)
            {
                count += 2;

                if (occurrences == 1)
                {
                    break;
                }

                frequency[current] = 0;
                current *= current;
            }

            if ((count & 1) == 0)
            {
                count--;
            }

            result = Math.Max(result, count);
        }

        return (int)result;
    }
}