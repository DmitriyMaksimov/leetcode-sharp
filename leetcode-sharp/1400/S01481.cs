namespace leetcode_sharp;

// 1481. Least Number of Unique Integers after K Removals
// https://leetcode.com/problems/least-number-of-unique-integers-after-k-removals
public class S01481
{
    public int FindLeastNumOfUniqueInts(int[] arr, int k)
    {
        var count = new Dictionary<int, int>();

        foreach (var n in arr)
        {
            count[n] = count.GetValueOrDefault(n) + 1;
        }

        var remaining = count.Count;
        var occur = 1;
        var occurrenceCount = new int[arr.Length + 1];

        foreach (var value in count.Values)
        {
            ++occurrenceCount[value];
        }

        while (k > 0)
        {
            if (k - occur * occurrenceCount[occur] >= 0)
            {
                k -= occur * occurrenceCount[occur];
                remaining -= occurrenceCount[occur++];
            }
            else
            {
                return remaining - k / occur;
            }
        }

        return remaining;
    }
}