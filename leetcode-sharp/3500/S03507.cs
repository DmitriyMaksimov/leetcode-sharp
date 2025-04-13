namespace leetcode_sharp;

// 3507. Minimum Pair Removal to Sort Array I
// https://leetcode.com/problems/minimum-pair-removal-to-sort-array-i
public class S03507
{
    public int MinimumPairRemoval(int[] nums)
    {
        var result = 0;
        var numList = nums.ToList();

        while (!IsNonDecreasing(numList))
        {
            var minSum = int.MaxValue;
            var minIndex = -1;

            for (var i = 0; i < numList.Count - 1; i++)
            {
                var pairSum = numList[i] + numList[i + 1];
                if (pairSum < minSum)
                {
                    minSum = pairSum;
                    minIndex = i;
                }
            }

            var newNum = numList[minIndex] + numList[minIndex + 1];
            numList.RemoveAt(minIndex + 1);
            numList[minIndex] = newNum;

            result++;
        }

        return result;
    }

    private static bool IsNonDecreasing(List<int> list)
    {
        for (var i = 0; i < list.Count - 1; i++)
        {
            if (list[i] > list[i + 1])
            {
                return false;
            }
        }

        return true;
    }
}
