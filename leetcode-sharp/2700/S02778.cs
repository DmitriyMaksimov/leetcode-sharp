namespace leetcode_sharp;

// 2778. Sum of Squares of Special Elements
// https://leetcode.com/problems/sum-of-squares-of-special-elements
public class S02778
{
    public int SumOfSquares(int[] nums)
    {
        return nums.Where((_, i) => nums.Length % (i + 1) == 0).Sum(x => x * x);
    }
}