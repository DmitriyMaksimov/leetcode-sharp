namespace leetcode_sharp;

// 1409. Queries on a Permutation With Key
// https://leetcode.com/problems/queries-on-a-permutation-with-key
public class S01409
{
    public int[] ProcessQueries(int[] queries, int m)
    {
        var arr = new List<int>(Enumerable.Range(1, m));
        var answer = new int[queries.Length];

        for (var i = 0; i < queries.Length; i++)
        {
            for (var j = 0; j < arr.Count; j++)
            {
                if (queries[i] == arr[j])
                {
                    answer[i] = j;
                    arr.Insert(0, arr[j]);
                    arr.RemoveAt(j + 1);
                }
            }
        }

        return answer;
    }
}