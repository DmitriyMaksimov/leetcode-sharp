namespace leetcode_sharp;

// 1899. Merge Triplets to Form Target Triplet
// https://leetcode.com/problems/merge-triplets-to-form-target-triplet
public class S01899
{
    public bool MergeTriplets(int[][] triplets, int[] target)
    {
        var result = new bool[3];

        foreach (var triplet in triplets)
        {
            if (triplet[0] <= target[0] && triplet[1] <= target[1] && triplet[2] <= target[2])
            {
                result[0] |= triplet[0] == target[0];
                result[1] |= triplet[1] == target[1];
                result[2] |= triplet[2] == target[2];
            }
        }

        return result[0] && result[1] && result[2];
    }
}
