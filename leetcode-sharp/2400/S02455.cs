namespace leetcode_sharp;

// 2455. Average Value of Even Numbers That Are Divisible by Three
// https://leetcode.com/problems/average-value-of-even-numbers-that-are-divisible-by-three/
public class S02455
{
    public int AverageValue(int[] nums)
    {
        var ints = nums.Where(x => x % 2 == 0 && x % 3 == 0);
        return ints.Any() ? (int) ints.Average() : 0;
    }
}