namespace leetcode_sharp;

// 1630. Arithmetic Subarrays
// https://leetcode.com/problems/arithmetic-subarrays
public class S01630
{
    public IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r)
    {
        var result = new List<bool>();

        for (var i = 0; i < l.Length; i++)
        {
            var left = l[i];
            var right = r[i];

            var subarray = new int[right - left + 1];
            Array.Copy(nums, left, subarray, 0, right - left + 1);

            result.Add(isArithmeticSequence(subarray));
        }

        return result;
    }

    private static bool isArithmeticSequence(int[] arr)
    {
        Array.Sort(arr);

        var diff = arr[1] - arr[0];

        for (var i = 2; i < arr.Length; i++)
        {
            if (arr[i] - arr[i - 1] != diff)
            {
                return false;
            }
        }

        return true;
    }
}