namespace leetcode_sharp;

// 2418. Sort the People
// https://leetcode.com/problems/sort-the-people/
public class S02418
{
    public string[] SortPeople(string[] names, int[] heights)
    {
        return names.Zip(heights).OrderByDescending(x => x.Second).Select(x => x.First).ToArray();
    }
}