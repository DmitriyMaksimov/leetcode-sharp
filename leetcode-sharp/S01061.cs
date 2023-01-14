namespace leetcode_sharp;

// 1061. Lexicographically Smallest Equivalent String
// https://leetcode.com/problems/lexicographically-smallest-equivalent-string/
public class S01061
{
    public string SmallestEquivalentString(string s1, string s2, string baseStr)
    {
        var groups = createGroups(s1, s2);

        var result = "";
    
        foreach (var c in baseStr)
        {
            var found = false;
            
            foreach (var group in groups)
            {
                if (!group.Contains(c)) continue;
                result += group.MinBy(x => x);
                found = true;
                break;
            }

            if (!found)
            {
                result += c;
            }
        }
        
        return result;
    }

    private static List<HashSet<char>> createGroups(string s1, string s2)
    {
        var groups = new List<HashSet<char>>();
        for (var i = 0; i < s1.Length; i++)
        {
            var c1 = s1[i];
            var c2 = s2[i];
            var group1 = -1;
            var group2 = -1;

            for (var j = 0; j < groups.Count; j++)
            {
                var group = groups[j];

                if (group.Contains(c1))
                {
                    group1 = j;
                }

                if (group.Contains(c2))
                {
                    group2 = j;
                }
            }

            if (group1 == -1 && group2 == -1)
            {
                groups.Add(new HashSet<char> {c1, c2});
            }
            else if (group1 == group2)
            {
                groups[group1].Add(c1);
                groups[group1].Add(c2);
            }
            else if (group1 == -1)
            {
                groups[group2].Add(c1);
            }
            else if (group2 == -1)
            {
                groups[group1].Add(c2);
            }
            else
            {
                foreach (var c in groups[group2])
                {
                    groups[group1].Add(c);
                }

                groups.RemoveAt(group2);
            }
        }

        return groups;
    }
}