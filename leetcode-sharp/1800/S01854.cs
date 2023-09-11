namespace leetcode_sharp;

// 1854. Maximum Population Year
// https://leetcode.com/problems/maximum-population-year/
public class S01854
{
    public int MaximumPopulation(int[][] logs)
    {
        var years = new int[101];

        const int lowestYear = 1950;

        foreach (var log in logs)
        {
            for (var i = log[0]; i < log[1]; i++)
            {
                years[i - lowestYear]++;
            }
        }

        var max = 0;
        var maxYear = 0;
        
        for (var i = 0; i < years.Length; i++)
        {
            if (years[i] > max)
            {
                max = years[i];
                maxYear = i;
            }
        }

        return maxYear + lowestYear;
    }
}