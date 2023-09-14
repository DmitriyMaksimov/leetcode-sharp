namespace leetcode_sharp;

// 2148. Count Elements With Strictly Smaller and Greater Elements
// https://leetcode.com/problems/count-elements-with-strictly-smaller-and-greater-elements/
public class S02148
{
    public int CountElements(int[] nums)
    {
        if (nums.Length < 3)
        {
            return 0;
        }

        var arr = minMax(nums);

        return nums.Count(num => num != arr.min && num != arr.max);
    }

    private static (int min, int max) minMax(IReadOnlyList<int> arr)
    {
        var max = arr[0];
        var min = arr[0];

        foreach (var n in arr)
        {
            max = Math.Max(max, n);
            min = Math.Min(min, n);
        }

        return (min, max);
    }
}