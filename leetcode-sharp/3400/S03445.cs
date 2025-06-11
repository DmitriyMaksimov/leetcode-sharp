namespace leetcode_sharp;

// 3445. Maximum Difference Between Even and Odd Frequency II
// https://leetcode.com/problems/maximum-difference-between-even-and-odd-frequency-ii/
public class S03445
{
    public int MaxDifference(string s, int k)
    {
        var maxDifference = int.MinValue;

        foreach (var charA in "01234")
        {
            foreach (var charB in "01234")
            {
                if (charA == charB)
                {
                    continue;
                }

                var minSeenDifference = new Dictionary<(int, int), int>();

                // Prefix sums for occurrences of charA and charB
                var prefixA = new int[s.Length + 1];
                var prefixB = new int[s.Length + 1];

                var left = 0;

                for (var right = 0; right < s.Length; right++)
                {
                    prefixA[right + 1] = prefixA[right];
                    prefixB[right + 1] = prefixB[right];

                    if (s[right] == charA)
                    {
                        prefixA[right + 1]++;
                    }
                    else if (s[right] == charB)
                    {
                        prefixB[right + 1]++;
                    }

                    // Slide the left pointer to maintain the window
                    while (left <= right - k + 1 &&
                           prefixA[left] < prefixA[right + 1] &&
                           prefixB[left] < prefixB[right + 1])
                    {
                        var parityKey = (prefixA[left] % 2, prefixB[left] % 2);
                        var diffAtLeft = prefixA[left] - prefixB[left];

                        if (!minSeenDifference.ContainsKey(parityKey) || minSeenDifference[parityKey] > diffAtLeft)
                        {
                            minSeenDifference[parityKey] = diffAtLeft;
                        }

                        left++;
                    }

                    var desiredParityKey = (1 - prefixA[right + 1] % 2, prefixB[right + 1] % 2);
                    var currentDiff = prefixA[right + 1] - prefixB[right + 1];

                    if (minSeenDifference.TryGetValue(desiredParityKey, out var value))
                    {
                        var candidate = currentDiff - value;
                        maxDifference = Math.Max(maxDifference, candidate);
                    }
                }
            }
        }

        return maxDifference;
    }
}
