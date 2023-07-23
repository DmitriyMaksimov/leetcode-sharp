namespace leetcode_sharp;

// 2542. Maximum Subsequence Score
// https://leetcode.com/problems/maximum-subsequence-score/
public class S02542
{
    public long MaxScore(int[] nums1, int[] nums2, int k)
    {
        var n = nums1.Length;
        var arr = new (int n1, int n2)[n];

        for (var i = 0; i < n; i++)
        {
            arr[i] = (nums1[i], nums2[i]);
        }

        Array.Sort(arr, (a, b) => b.n2 - a.n2);

        var ans = 0L;
        var sum = 0L;
        var heap = new PriorityQueue<int, int>();

        for (var i = 0; i < n; i++)
        {
            heap.Enqueue(arr[i].n1, arr[i].n1);
            sum += arr[i].n1;

            if (i >= k)
            {
                sum -= heap.Dequeue();
            }

            if (i >= k - 1)
            {
                ans = Math.Max(ans, sum * arr[i].n2);
            }
        }

        return ans;
    }
}