namespace leetcode_sharp;

// 2465. Number of Distinct Averages
// https://leetcode.com/problems/number-of-distinct-averages
public class S02465
{
    public int DistinctAverages(int[] nums)
    {
        var counts = new Dictionary<int, int>();
        var minHeap = new SortedSet<(int val, int index)>();
        var maxHeap = new SortedSet<(int val, int index)>();
        var averages = new HashSet<double>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (!counts.ContainsKey(nums[i]))
            {
                counts[nums[i]] = 0;
            }

            counts[nums[i]]++;
            minHeap.Add((nums[i], i));
            maxHeap.Add((-nums[i], i));
        }

        while (counts.Count != 0)
        {
            var min = minHeap.Min;
            var max = maxHeap.Min;
            minHeap.Remove(min);
            maxHeap.Remove(max);

            var average = (min.val - max.val) / 2.0;
            averages.Add(average);

            counts[min.val]--;
            if (counts[min.val] == 0)
            {
                counts.Remove(min.val);
            }

            counts[-max.val]--;
            if (counts[-max.val] == 0)
            {
                counts.Remove(-max.val);
            }
        }

        return averages.Count;
    }
}