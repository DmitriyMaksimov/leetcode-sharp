namespace leetcode_sharp;

// 2106. Maximum Fruits Harvested After at Most K Steps
// https://leetcode.com/problems/maximum-fruits-harvested-after-at-most-k-steps
public class S02106
{
    private const int MaxSize = (100_000 + 1) * 2;

    public int MaxTotalFruits(int[][] fruits, int startPos, int k)
    {
        var adjustedStart = startPos + 1;
        var prefixSum = new int[MaxSize];

        foreach (var fruit in fruits)
        {
            var position = fruit[0] + 1;
            var amount = fruit[1];
            prefixSum[position] = amount;
        }

        for (var i = 1; i < MaxSize; i++)
        {
            prefixSum[i] += prefixSum[i - 1];
        }

        var maxFruits = 0;

        // Case 1: Move right first
        for (var r = adjustedStart; r < MaxSize && r <= adjustedStart + k; r++)
        {
            var stepsRight = r - adjustedStart;
            var stepsLeft = k - 2 * stepsRight;
            var l = Math.Min(adjustedStart, adjustedStart - stepsLeft);
            l = Math.Max(1, l);

            var collected = prefixSum[r] - prefixSum[l - 1];
            maxFruits = Math.Max(maxFruits, collected);
        }

        // Case 2: Move left first
        for (var l = adjustedStart; l > 0 && l >= adjustedStart - k; l--)
        {
            var stepsLeft = adjustedStart - l;
            var stepsRight = k - 2 * stepsLeft;
            var r = Math.Max(adjustedStart, adjustedStart + stepsRight);
            r = Math.Min(MaxSize - 1, r);

            var collected = prefixSum[r] - prefixSum[l - 1];
            maxFruits = Math.Max(maxFruits, collected);
        }

        return maxFruits;
    }
}