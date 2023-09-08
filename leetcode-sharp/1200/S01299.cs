namespace leetcode_sharp;

// 1299. Replace Elements with Greatest Element on Right Side
// https://leetcode.com/problems/replace-elements-with-greatest-element-on-right-side/
public class S01299
{
    public int[] ReplaceElements(int[] arr)
    {
        var max = -1;
        for (var i = arr.Length - 1; i >= 0; i--)
        {
            var temp = arr[i];
            arr[i] = max;
            max = Math.Max(max, temp);
        }

        return arr;
    }
}