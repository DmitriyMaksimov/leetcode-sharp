namespace leetcode_sharp;

// 3080. Mark Elements on Array by Performing Queries
// https://leetcode.com/problems/mark-elements-on-array-by-performing-queries
public class S03080
{
    public long[] UnmarkedSumArray(int[] nums, int[][] queries)
    {
        var totalSum = nums.Aggregate(0L, (acc, num) => acc + num);
        var result = new List<long>();

        var unmarkedNumbers = new SortedSet<(int, int)>(Comparer<(int, int)>.Create(
            (a, b) => a.Item1 != b.Item1 ? a.Item1.CompareTo(b.Item1) : a.Item2.CompareTo(b.Item2)
        ));

        for (var i = 0; i < nums.Length; i++)
        {
            unmarkedNumbers.Add((nums[i], i));
        }

        foreach (var query in queries)
        {
            var indexToRemove = query[0];
            var countToRemove = query[1];

            var current = (nums[indexToRemove], indexToRemove);
            if (unmarkedNumbers.Contains(current))
            {
                totalSum -= nums[indexToRemove];
                unmarkedNumbers.Remove(current);
            }

            while (countToRemove > 0 && unmarkedNumbers.Count > 0)
            {
                var smallest = unmarkedNumbers.Min;
                totalSum -= smallest.Item1;
                unmarkedNumbers.Remove(smallest);
                countToRemove--;
            }

            result.Add(totalSum);
        }
        
        return result.ToArray();
    }
}