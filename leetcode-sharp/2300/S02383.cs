namespace leetcode_sharp;

// 2383. Minimum Hours of Training to Win a Competition
// https://leetcode.com/problems/minimum-hours-of-training-to-win-a-competition/
public class S02383
{
    public int MinNumberOfHours(int initialEnergy, int initialExperience, int[] energy, int[] experience)
    {
        var sum = energy.Sum();
        var res = sum - initialEnergy >= 0 ? sum - initialEnergy + 1 : 0;
        
        // if curExp < opponents‘ exp, we need to train
        foreach (var exp in experience)
        {
            if (initialExperience <= exp)
            {
                res += exp - initialExperience + 1;
                initialExperience = exp + 1;
            }

            initialExperience += exp;
        }

        return res;
    }
}