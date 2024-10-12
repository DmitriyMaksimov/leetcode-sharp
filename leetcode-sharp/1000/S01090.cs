namespace leetcode_sharp;

// 1090. Largest Values From Labels
// https://leetcode.com/problems/largest-values-from-labels
public class S01090
{
    public int LargestValsFromLabels(int[] values, int[] labels, int numWanted, int useLimit)
    {
        Array.Sort(values, labels);

        var usedLabels = new Dictionary<int, int>();
        var sum = 0;

        for (var i = values.Length - 1; i >= 0 && numWanted > 0; i--)
        {
            usedLabels.TryAdd(labels[i], useLimit);

            if (usedLabels[labels[i]] > 0)
            {
                sum += values[i];
                numWanted--;
                usedLabels[labels[i]]--;
            }
        }

        return sum;
    }
}
