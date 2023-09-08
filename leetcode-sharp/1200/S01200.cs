namespace leetcode_sharp;

// 1200. Minimum Absolute Difference
// https://leetcode.com/problems/minimum-absolute-difference/
public class S01200
{
    public IList<IList<int>> MinimumAbsDifference(int[] arr)
    {
        Array.Sort(arr);

        var min = int.MaxValue;
        
        for (var i = 0; i < arr.Length - 1; i++)
        {
            var diff = Math.Abs(arr[i] - arr[i + 1]);
            min = Math.Min(min, diff);
        }

        var ans = new List<IList<int>>();

        for (var i = 0; i < arr.Length - 1; i++)
        {
            var diff = Math.Abs(arr[i] - arr[i + 1]);
        
            if (diff == min)
            {
                ans.Add(new List<int> {arr[i], arr[i + 1]});
            }
        }

        return ans;
    }
}