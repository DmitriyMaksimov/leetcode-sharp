namespace leetcode_sharp;

// 789. Escape The Ghosts
// https://leetcode.com/problems/escape-the-ghosts
public class S00789
{
    public bool EscapeGhosts(int[][] ghosts, int[] target)
    {
        var distance = Math.Abs(target[0]) + Math.Abs(target[1]);

        return ghosts.All(ghost => distance < Math.Abs(target[0] - ghost[0]) + Math.Abs(target[1] - ghost[1]));
    }
}
