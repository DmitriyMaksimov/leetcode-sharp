namespace leetcode_sharp;

// 3718. Smallest Missing Multiple of K
// https://leetcode.com/problems/smallest-missing-multiple-of-k
public class S03718
{
    public int MissingMultiple(int[] nums, int k)
    {
        var hashSet = nums.ToHashSet();
        var n = k;
        
        while (hashSet.Contains(n))
        {
            n += k;
        }

        return n;
    }
}