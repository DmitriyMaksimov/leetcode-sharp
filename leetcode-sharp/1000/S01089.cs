namespace leetcode_sharp;

// 1089. Duplicate Zeros
// https://leetcode.com/problems/duplicate-zeros/
public class S01089
{
    public void DuplicateZeros(int[] arr)
    {
        var len = arr.Length;
        var i = 0;
        while (i < len)
        {
            if (arr[i] == 0)
            {
                for (var j = len - 1; j > i; j--)
                {
                    arr[j] = arr[j - 1];
                }

                i++;
            }

            i++;
        }
    }
}