namespace leetcode_sharp;

// 3259. Maximum Energy Boost From Two Drinks
// https://leetcode.com/problems/maximum-energy-boost-from-two-drinks
public class S03259
{
    public long MaxEnergyBoost(int[] energyDrinkA, int[] energyDrinkB)
    {
        var n = energyDrinkA.Length;
        var dp = new long[2, n];

        dp[0, n - 1] = energyDrinkA[n - 1];
        dp[1, n - 1] = energyDrinkB[n - 1];

        for (var currHour = n - 2; currHour >= 0; currHour--)
        {
            for (var currDrinkType = 0; currDrinkType <= 1; currDrinkType++)
            {
                var drinkBoost = currDrinkType == 0 ? energyDrinkA[currHour] : energyDrinkB[currHour];
                var noTypeSwitch = drinkBoost + dp[currDrinkType, currHour + 1];
                var typeSwitch = drinkBoost + (currHour + 2 >= n ? 0 : dp[1 - currDrinkType, currHour + 2]);

                dp[currDrinkType, currHour] = Math.Max(noTypeSwitch, typeSwitch);
            }
        }

        return Math.Max(dp[0, 0], dp[1, 0]);
    }
}
