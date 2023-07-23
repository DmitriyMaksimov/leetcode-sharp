namespace leetcode_sharp;

// 997. Find the Town Judge
// https://leetcode.com/problems/find-the-town-judge/
public class S00997
{
    public int FindJudge(int n, int[][] trust)
    {
        var trusted = new int[n + 1];
        var trustSomeone = new bool[n + 1];
        
        foreach (var pair in trust)
        {
            trusted[pair[1]]++;
            trustSomeone[pair[0]] = true;
        }

        for (var i = 1; i <= n; i++)
        {
            if (!trustSomeone[i] && trusted[i] == n - 1)
            {
                return i;
            }
        }
        
        return -1;
    }
}