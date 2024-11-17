namespace leetcode_sharp;

// 3318. Find X-Sum of All K-Long Subarrays I
// https://leetcode.com/problems/find-x-sum-of-all-k-long-subarrays-i
public class S03318
{
    public int[] FindXSum(int[] nums, int k, int x)
    {
        var result = new int[nums.Length - k + 1];

        for (var i = 0; i < result.Length; i++)
        {
            var sum = 0;
            var set = new HashSet<int>();
            var map = new Dictionary<int, int>();

            for (var j = i; j < i + k; j++)
            {
                sum += nums[j];
                set.Add(nums[j]);
                map[nums[j]] = map.GetValueOrDefault(nums[j]) + 1;
            }

            if (set.Count < x)
            {
                result[i] = sum;
            }
            else
            {
                var pq = new PriorityQueue<int, (int Frequency, int Value)>();
                foreach (var ele in set)
                {
                    pq.Enqueue(ele, (-map[ele], -ele));
                }

                var count = x;
                while (count-- > 0)
                {
                    var top = pq.Dequeue();
                    result[i] += top * map[top];
                }
            }
        }

        return result;
    }
}
