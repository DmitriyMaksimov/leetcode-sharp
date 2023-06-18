namespace leetcode_sharp;

// 1534. Count Good Triplets
// https://leetcode.com/problems/count-good-triplets/
public class S01534
{
    public int CountGoodTriplets(int[] arr, int a, int b, int c)
    {
        var count = 0;

        for (var i = 0; i < arr.Length; i++)
        {
            for (var j = i + 1; j < arr.Length; j++)
            {
                for (var k = j + 1; k < arr.Length; k++)
                {
                    if (Math.Abs(arr[i] - arr[j]) <= a && Math.Abs(arr[j] - arr[k]) <= b && Math.Abs(arr[i] - arr[k]) <= c)
                    {
                        count++;
                    }
                }
            }
        }

        return count;
    }
}