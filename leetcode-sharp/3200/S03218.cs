namespace leetcode_sharp;

// 3218. Minimum Cost for Cutting Cake I
// https://leetcode.com/problems/minimum-cost-for-cutting-cake-i
public class S03218
{
    public int MinimumCost(int m, int n, int[] horizontalCut, int[] verticalCut)
    {
        Array.Sort(horizontalCut, (a, b) => b.CompareTo(a));
        Array.Sort(verticalCut, (a, b) => b.CompareTo(a));

        var hIndex = 0;
        var vIndex = 0;
        var horizontalPieces = 1;
        var verticalPieces = 1;
        var totalCost = 0;

        // Continue until all cuts are made
        while (hIndex < horizontalCut.Length && vIndex < verticalCut.Length)
        {
            if (horizontalCut[hIndex] > verticalCut[vIndex])
            {
                totalCost += horizontalCut[hIndex++] * verticalPieces;
                horizontalPieces++;
            }
            else
            {
                totalCost += verticalCut[vIndex++] * horizontalPieces;
                verticalPieces++;
            }
        }

        while (hIndex < horizontalCut.Length)
        {
            totalCost += horizontalCut[hIndex++] * verticalPieces;
        }

        while (vIndex < verticalCut.Length)
        {
            totalCost += verticalCut[vIndex++] * horizontalPieces;
        }

        return totalCost;
    }
}
