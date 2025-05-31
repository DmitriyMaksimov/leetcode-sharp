namespace leetcode_sharp;

// 658. Find K Closest Elements
// https://leetcode.com/problems/find-k-closest-elements
public class S00658
{
    public IList<int> FindClosestElements(int[] arr, int k, int x)
    {
        var low = 0;
        var high = arr.Length - 1;

        while (high - low >= k)
        {
            if (Math.Abs(arr[low] - x) > Math.Abs(arr[high] - x))
            {
                low++;
            }
            else
            {
                high--;
            }
        }

        return new List<int>(arr.AsSpan(low, high - low + 1).ToArray());
    }
}

