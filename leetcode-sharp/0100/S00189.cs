namespace leetcode_sharp;

// 189. Rotate Array
// https://leetcode.com/problems/rotate-array/
public class S00189
{
    public void Rotate(int[] nums, int k)
    {
        var length = nums.Length;
        k %= length;

        if (k > 0)
        {
            var array = nums.TakeLast(k).Concat(nums.SkipLast(k)).ToArray();
            array.CopyTo(nums, 0);
        }
    }
}