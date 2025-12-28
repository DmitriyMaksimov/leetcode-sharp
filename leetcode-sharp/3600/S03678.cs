namespace leetcode_sharp;

// 3678. Smallest Absent Positive Greater Than Average
// https://leetcode.com/problems/smallest-absent-positive-greater-than-average
public class S03678
{
    public int SmallestAbsent(int[] nums)
    {
        var hashSet = new HashSet<int>();
        var sum = 0L;

        foreach (var x in nums)
        {
            hashSet.Add(x);
            sum += x;
        }

        var average = (double)sum / nums.Length;
        var result = Math.Max(1, (int)Math.Floor(average) + 1);

        while (hashSet.Contains(result))
        {
            result++;
        }

        return result;
    }
}