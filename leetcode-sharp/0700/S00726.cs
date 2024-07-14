using System.Text;

namespace leetcode_sharp;

// 726. Number of Atoms
// https://leetcode.com/problems/number-of-atoms
public class S00726
{
    public string CountOfAtoms(string formula)
    {
        var dictionary = CountHelper(formula);

        var sb = new StringBuilder();

        foreach (var atom in dictionary.Keys.Order())
        {
            sb.Append(atom + (dictionary[atom] > 1 ? dictionary[atom] : ""));
        }

        return sb.ToString();
    }

    private static Dictionary<string, int> CountHelper(string formula)
    {
        Dictionary<string, int> dictionary = [];

        if (formula.Length == 0)
        {
            return dictionary;
        }

        var i = 0;

        while (i < formula.Length)
        {
            if (formula[i] == '(')
            {
                int count = 0, j = i;
                for (; j < formula.Length; j++)
                {
                    if (formula[j] == '(')
                    {
                        count++;
                    }
                    else if (formula[j] == ')')
                    {
                        count--;
                    }

                    if (count == 0)
                    {
                        break;
                    }
                }

                var subDictionary = CountHelper(formula.Substring(i + 1, j - (i + 1)));

                j++;
                int n = 1, k = j;
                while (k < formula.Length && Char.IsDigit(formula[k]))
                {
                    k++;
                }

                if (k > j)
                {
                    n = int.Parse(formula.Substring(j, k - j));
                }

                foreach (var atom in subDictionary.Keys)
                {
                    dictionary[atom] = subDictionary[atom] * n + dictionary.GetValueOrDefault(atom);
                }

                i = k;
            }
            else
            {
                var j = i + 1;
                while (j < formula.Length && formula[j] >= 'a' && formula[j] <= 'z')
                {
                    j++;
                }

                var n = 1;
                var k = j;
                while (k < formula.Length && Char.IsDigit(formula[k]))
                {
                    k++;
                }

                if (k > j)
                {
                    n = int.Parse(formula.Substring(j, k - j));
                }

                var atom = formula.Substring(i, j - i);
                dictionary[atom] = n + dictionary.GetValueOrDefault(atom);

                i = k;
            }
        }

        return dictionary;
    }
}