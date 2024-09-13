namespace leetcode_sharp;

// 2358. Maximum Number of Groups Entering a Competition
// https://leetcode.com/problems/maximum-number-of-groups-entering-a-competition
public class S02358
{
    public int MaximumGroups(int[] grades)
    {
        var k = 0;
        var total = 0;

        while (total + k + 1 <= grades.Length)
        {
            total += ++k;
        }

        return k;
    }
}
