namespace leetcode_sharp;

// 3147. Taking Maximum Energy From the Mystic Dungeon
// https://leetcode.com/problems/taking-maximum-energy-from-the-mystic-dungeon
public class S03147
{
    public int MaximumEnergy(int[] energy, int k)
    {
        var dp = new int[energy.Length];
        var result = int.MinValue;

        for (var i = energy.Length - 1; i >= 0; i--)
        {
            dp[i] = energy[i] + (i + k < energy.Length ? dp[i + k] : 0);
            result = Math.Max(result, dp[i]);
        }

        return result;
    }
}