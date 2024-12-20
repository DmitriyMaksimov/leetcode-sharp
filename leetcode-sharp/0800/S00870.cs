namespace leetcode_sharp;

// 870. Advantage Shuffle
// https://leetcode.com/problems/advantage-shuffle
public class S00870
{
    public int[] AdvantageCount(int[] nums1, int[] nums2)
    {
        Array.Sort(nums1);
        var n = nums1.Length;
        var res = new int[n];

        var pq = new SortedList<int, Queue<int>>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
        for (var i = 0; i < n; i++)
        {
            pq.TryAdd(nums2[i], []);
            pq[nums2[i]].Enqueue(i);
        }

        var lo = 0;
        var hi = n - 1;

        foreach (var pair in pq)
        {
            while (pair.Value.Count > 0)
            {
                var idx = pair.Value.Dequeue();

                res[idx] = nums1[hi] > pair.Key ? nums1[hi--] : nums1[lo++];
            }
        }

        return res;
    }
}
