namespace leetcode_sharp;

// 893. Groups of Special-Equivalent Strings
// https://leetcode.com/problems/groups-of-special-equivalent-strings
public class S00893
{
    public int NumSpecialEquivGroups(string[] words)
    {
        HashSet<string> hashSet = [];

        foreach (var word in words)
        {
            var odd = new int[26];
            var even = new int[26];

            for (var i = 0; i < word.Length; i++)
            {
                var index = word[i] - 'a';

                if (i % 2 == 0)
                {
                    even[index]++;
                }
                else
                {
                    odd[index]++;
                }
            }

            hashSet.Add(string.Join("_", odd.Concat(even)));
        }

        return hashSet.Count;
    }
}