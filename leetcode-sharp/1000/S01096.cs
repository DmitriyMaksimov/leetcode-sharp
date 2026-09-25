namespace leetcode_sharp;

// 1096. Brace Expansion II
// https://leetcode.com/problems/brace-expansion-ii
public class S01096
{
    public IList<string> BraceExpansionII(string expression)
    {
        var groups = new List<List<IList<string>>> { new() };
        var level = 0;
        var start = 0;

        for (var i = 0; i < expression.Length; i++)
        {
            var c = expression[i];

            switch (c)
            {
                case '{':
                {
                    if (level == 0)
                    {
                        start = i + 1;
                    }

                    level++;
                    break;
                }
                case '}':
                {
                    level--;

                    if (level == 0)
                    {
                        groups[^1].Add(BraceExpansionII(expression.Substring(start, i - start)));
                    }

                    break;
                }
                case ',' when level == 0:
                    groups.Add(new List<IList<string>>());
                    break;
                default:
                {
                    if (level == 0)
                    {
                        groups[^1].Add(new List<string> { c.ToString() });
                    }

                    break;
                }
            }
        }

        var wordSet = new HashSet<string>();

        foreach (var word in groups.SelectMany(Product))
        {
            wordSet.Add(word);
        }

        return [.. wordSet.Order()];
    }

    private static IEnumerable<string> Product(List<IList<string>> group)
    {
        IEnumerable<string> result = [""];

        return group.Aggregate(result, (current, options) => current.SelectMany(_ => options, (prefix, option) => prefix + option));
    }
}