namespace leetcode_sharp;

// 907. Sum of Subarray Minimums
// https://leetcode.com/problems/sum-of-subarray-minimums
public class S00907
{
    public int SumSubarrayMins(int[] arr)
    {
        var stack = new Stack<long>();
        var sums = new long [arr.Length];

        long j;
        const long mod = 1000000007;
        for (var i = 0; i < arr.Length; ++i)
        {
            while (stack.Any() && arr[stack.Peek()] > arr[i])
                stack.Pop();

            j = stack.Any() ? stack.Peek() : -1;
            
            sums[i] = ((j >= 0 ? sums[j] : 0) + (i - j) * arr[i]) % mod;
            stack.Push(i);
        }

        var res = sums.Aggregate<long, long>(0, (current, sum) => (current + sum) % mod);

        return (int)res;
    }
}