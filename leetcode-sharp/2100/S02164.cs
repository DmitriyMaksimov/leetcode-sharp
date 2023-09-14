namespace leetcode_sharp;

// 2164. Sort Even and Odd Indices Independently
// https://leetcode.com/problems/sort-even-and-odd-indices-independently/
public class S02164
{
    public int[] SortEvenOdd(int[] nums)
    {
        var evens = new List<int>((nums.Length + 1) / 2);
        var odds = new List<int>(evens.Count);

        foreach (var n in nums)
        {
            ((evens.Count <= odds.Count) ? evens : odds).Add(n);
        }

        evens.Sort();
        odds.Sort((a, b) => b - a);

        for (var i = 0; i < nums.Length; i += 2)
        {
            nums[i] = evens[i / 2];
        }

        for (var i = 1; i < nums.Length; i += 2)
        {
            nums[i] = odds[i / 2];
        }

        return nums;
    }
}