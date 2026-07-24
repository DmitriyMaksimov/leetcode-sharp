namespace leetcode_sharp;

// 3514. Number of Unique XOR Triplets II
// https://leetcode.com/problems/number-of-unique-xor-triplets-ii
public class S03514
{
    public int UniqueXorTriplets(int[] nums)
    {
        var pairXors = new HashSet<int>();
        var tripletXors = new HashSet<int>();
        var n = nums.Length;

        for (var i = 0; i < n; i++)
        {
            for (var j = i; j < n; j++)
            {
                pairXors.Add(nums[i] ^ nums[j]);
            }
        }

        foreach (var pairXor in pairXors)
        {
            foreach (var x in nums)
            {
                tripletXors.Add(pairXor ^ x);
            }
        }

        return tripletXors.Count;
    }
}