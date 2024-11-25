namespace leetcode_sharp;

// 3015. Count the Number of Houses at a Certain Distance I
// https://leetcode.com/problems/count-the-number-of-houses-at-a-certain-distance-i
public class S03015
{
    public int[] CountOfPairs(int n, int x, int y)
    {
        var ans = new int[n];
        for (var i = 1; i <= n; i++)
        {
            for (var j = i + 1; j <= n; j++)
            {
                var val = Math.Min(Math.Abs(i - j), Math.Min(Math.Abs(i - x) + 1 + Math.Abs(y - j), Math.Abs(i - y) + 1 + Math.Abs(x - j)));
                ans[val - 1] += 2;
            }
        }

        return ans;
    }
}
