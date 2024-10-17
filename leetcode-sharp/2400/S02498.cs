namespace leetcode_sharp;

// 2498. Frog Jump II
// https://leetcode.com/problems/frog-jump-ii
public class S02498
{
    public int MaxJump(int[] stones)
    {
        var res = stones[1] - stones[0];

        for (var i = 3; i < stones.Length; i += 2)
        {
            res = Math.Max(res, stones[i] - stones[i - 2]);
        }

        for (var i = 2; i < stones.Length; i += 2)
        {
            res = Math.Max(res, stones[i] - stones[i - 2]);
        }

        return res;
    }
}
