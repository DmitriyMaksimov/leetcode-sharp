namespace leetcode_sharp;

// 
// https://leetcode.com/problems/valid-mountain-array/
public class S00941
{
    public bool ValidMountainArray(int[] arr)
    {
        if (arr.Length < 3)
        {
            return false;
        }

        var i = 0;

        while (i < arr.Length - 1 && arr[i] < arr[i + 1])
        {
            i++;
        }

        if (i == 0 || i == arr.Length - 1)
        {
            return false;
        }

        while (i < arr.Length - 1 && arr[i] > arr[i + 1])
        {
            i++;
        }

        return i == arr.Length - 1;
    }
}