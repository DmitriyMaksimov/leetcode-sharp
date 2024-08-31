namespace leetcode_sharp;

// 3211. Generate Binary Strings Without Adjacent Zeros
// https://leetcode.com/problems/generate-binary-strings-without-adjacent-zeros
public class S03211
{
    public IList<string> ValidStrings(int n)
    {
        List<string> result = ["0", "1"];

        while (--n > 0)
        {
            result = BuildNextListOfValidStrings(result);
        }

        return result;
    }

    private static List<string> BuildNextListOfValidStrings(IList<string> list)
    {
        List<string> result = [];

        foreach (var str in list)
        {
            result.Add(str + '1');
            if (str[^1] == '1')
            {
                result.Add(str + '0');
            }
        }

        return result;
    }
}
