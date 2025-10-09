namespace leetcode_sharp;

// 3494. Find the Minimum Amount of Time to Brew Potions
// https://leetcode.com/problems/find-the-minimum-amount-of-time-to-brew-potions
public class S03494
{
    public long MinTime(int[] skill, int[] mana)
    {
        var result = new long[skill.Length + 1];

        foreach (long currentMana in mana)
        {
            for (var i = 0; i < skill.Length; i++)
            {
                result[i + 1] = Math.Max(result[i + 1], result[i]) + currentMana * skill[i];
            }

            for (var i = skill.Length - 1; i > 0; i--)
            {
                result[i] = result[i + 1] - currentMana * skill[i];
            }
        }

        return result[skill.Length];
    }
}