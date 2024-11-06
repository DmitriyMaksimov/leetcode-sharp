namespace leetcode_sharp;

// 2924. Find Champion II
// https://leetcode.com/problems/find-champion-ii
public class S02924
{
    public int FindChampion(int n, int[][] edges)
    {
        List<bool> lost = [..new bool[n]];

        foreach (var e in edges)
        {
            lost[e[1]] = true;
        }

        var j = lost.IndexOf(false);

        return lost.Count(x => !x) == 1 ? j : -1;
    }
}
