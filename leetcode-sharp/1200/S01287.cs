namespace leetcode_sharp;

// 1287. Element Appearing More Than 25% In Sorted Array
// https://leetcode.com/problems/element-appearing-more-than-25-in-sorted-array/
public class S01287
{
    public int FindSpecialInteger(int[] arr)
    {
        var count = arr.Length / 4;
        var current = arr[0];
        var currentCount = 1;

        for (var i = 1; i < arr.Length; i++)
        {
            if (arr[i] != current)
            {
                current = arr[i];
                currentCount = 1;
            }
            else
            {
                currentCount++;
                if (currentCount > count)
                {
                    return current;
                }
            }
        }

        return current;
    }
}