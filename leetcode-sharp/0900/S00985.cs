namespace leetcode_sharp;

// 985. Sum of Even Numbers After Queries
// https://leetcode.com/problems/sum-of-even-numbers-after-queries
public class S00985
{
    public int[] SumEvenAfterQueries(int[] nums, int[][] queries)
    {
        var sum = nums.Sum(num => num % 2 == 0 ? num : 0);
        var answer = new int[queries.Length];

        for (var i = 0; i < queries.Length; ++i)
        {
            var idx = queries[i][1];

            if (nums[idx] % 2 == 0)
            {
                sum -= nums[idx];
            }

            nums[idx] += queries[i][0];

            if (nums[idx] % 2 == 0)
            {
                sum += nums[idx];
            }

            answer[i] = sum;
        }

        return answer;
    }
}
