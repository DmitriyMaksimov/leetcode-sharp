namespace leetcode_sharp;

// 1053. Previous Permutation With One Swap
// https://leetcode.com/problems/previous-permutation-with-one-swap
public class S01053
{
    public int[] PrevPermOpt1(int[] arr)
    {
        if (arr.Length <= 1)
        {
            return arr;
        }

        var idx = -1;

        for (var i = arr.Length - 1; i >= 1; i--)
        {
            if (arr[i] < arr[i - 1])
            {
                idx = i - 1;
                break;
            }
        }

        if (idx == -1)
        {
            return arr;
        }

        for (var i = arr.Length - 1; i > idx; i--)
        {
            if (arr[i] < arr[idx] && arr[i] != arr[i - 1])
            {
                (arr[i], arr[idx]) = (arr[idx], arr[i]);
                break;
            }
        }

        return arr;
    }
}
