namespace leetcode_sharp;

// 2545. Sort the Students by Their Kth Score
// https://leetcode.com/problems/sort-the-students-by-their-kth-score
public class S02545
{
    public int[][] SortTheStudents(int[][] score, int k)
    {
        var list = score.ToList();
        list.Sort((x, y) => y[k] - x[k]);
        return list.ToArray();
    }
}