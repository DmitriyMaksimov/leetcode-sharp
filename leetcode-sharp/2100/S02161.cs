namespace leetcode_sharp;

// 2161. Partition Array According to Given Pivot
// https://leetcode.com/problems/partition-array-according-to-given-pivot
public class S02161
{
    public int[] PivotArray(int[] nums, int pivot)
    {
        var less = new List<int>();
        var equal = new List<int>();
        var greater = new List<int>();

        foreach (var n in nums)
        {
            if (n < pivot) less.Add(n);
            else if (n == pivot) equal.Add(n);
            else  greater.Add(n);
        }

        return less.Concat(equal).Concat(greater).ToArray();
    }
}