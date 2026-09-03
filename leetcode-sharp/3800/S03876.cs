namespace leetcode_sharp;

// 3876. Construct Uniform Parity Array II
// https://leetcode.com/problems/construct-uniform-parity-array-ii
public class S03876
{
    public bool UniformArray(int[] nums)
    {
        var min = nums.Min();
        var odd = nums.Any(x => x % 2 == 1);

        return ((min % 2) == 1) == odd;
    }
}