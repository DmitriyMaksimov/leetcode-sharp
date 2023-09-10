namespace leetcode_sharp;

// 1619. Mean of Array After Removing Some Elements
// https://leetcode.com/problems/mean-of-array-after-removing-some-elements/
public class S01619
{
    public double TrimMean(int[] arr)
    {
        Array.Sort(arr);
        var n = arr.Length;
        
        var start = n / 20;
        var end = n - start;
        var sum = 0;
        
        for (var i = start; i < end; i++)
        {
            sum += arr[i];
        }
        return (double)sum / (end - start);
    }
}