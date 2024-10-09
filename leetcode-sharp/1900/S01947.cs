namespace leetcode_sharp;

// 1947. Maximum Compatibility Score Sum
// https://leetcode.com/problems/maximum-compatibility-score-sum
public class S01947
{
    private int _max;
    private bool[] _visited = null!;

    public int MaxCompatibilitySum(int[][] students, int[][] mentors)
    {
        _visited = new bool[students.Length];
        Helper(students, mentors, 0, 0);
        return _max;
    }

    private void Helper(int[][] students, int[][] mentors, int pos, int score)
    {
        if (pos >= students.Length)
        {
            _max = Math.Max(_max, score);
            return;
        }

        for (var i = 0; i < mentors.Length; i++)
        {
            if (_visited[i]) continue;

            _visited[i] = true;
            Helper(students, mentors, pos + 1, score + ComputeScore(students[pos], mentors[i]));
            _visited[i] = false;
        }
    }

    private static int ComputeScore(int[] a, int[] b)
    {
        return b.Where((t, i) => a[i] == t).Count();
    }
}
