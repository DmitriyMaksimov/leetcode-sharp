namespace leetcode_sharp;

// 1282. Group the People Given the Group Size They Belong To
// https://leetcode.com/problems/group-the-people-given-the-group-size-they-belong-to/
public class S01282
{
    public IList<IList<int>> GroupThePeople(int[] groupSizes)
    {
        var result = new List<IList<int>>();
        var dict = new Dictionary<int, List<int>>();

        for (var i = 0; i < groupSizes.Length; i++)
        {
            var size = groupSizes[i];
            if (!dict.ContainsKey(size))
            {
                dict.Add(size, []);
            }

            dict[size].Add(i);

            if (dict[size].Count == size)
            {
                result.Add(dict[size]);
                dict.Remove(size);
            }
        }

        return result;
    }
}