namespace leetcode_sharp;

// 486. Predict the Winner
// https://leetcode.com/problems/predict-the-winner/
public class S00486
{
    public bool PredictTheWinner(int[] nums)
    {
        var n = nums.Length;
        var arr = new int[n];

        for (var i = n - 1; i >= 0; i--)
        {
            arr[i] = nums[i];

            for (var j = i + 1; j < n; j++)
            {
                arr[j] = Math.Max(nums[i] - arr[j], nums[j] - arr[j - 1]);
            }
        }

        return arr[n - 1] >= 0;
    }
}