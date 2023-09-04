namespace leetcode_sharp;

// 888. Fair Candy Swap
// https://leetcode.com/problems/fair-candy-swap/
public class S00888
{
    public int[] FairCandySwap(int[] aliceSizes, int[] bobSizes)
    {
        var aliceSum = aliceSizes.Sum();
        var bobSum = bobSizes.Sum();
        var diff = (aliceSum - bobSum) / 2;
        var bobSet = new HashSet<int>(bobSizes);

        foreach (var a in aliceSizes)
        {
            var b = a - diff;
            if (bobSet.Contains(b))
            {
                return new[] {a, b};
            }
        }

        return Array.Empty<int>();
    }
}