namespace leetcode_sharp;

// 128. Longest Consecutive Sequence
// https://leetcode.com/problems/longest-consecutive-sequence/
public class S00128
{
    public int LongestConsecutive(int[] nums)
    {
        var map = new Dictionary<int, (int left, int right)>();
        var visited = new HashSet<int>();
        var longestConsecutive = 0;

        foreach (var i in nums)
        {
            if (visited.Contains(i))
            {
                continue;
            }

            visited.Add(i);

            var left = i;
            var right = i;

            if (map.ContainsKey(i + 1))
            {
                right = map[i + 1].right;
            }

            if (map.ContainsKey(i - 1))
            {
                left = map[i - 1].left;
            }

            map[right] = (left, right);
            map[left] = (left, right);

            longestConsecutive = Math.Max(longestConsecutive, right - left + 1);
        }

        return longestConsecutive;
    }
}