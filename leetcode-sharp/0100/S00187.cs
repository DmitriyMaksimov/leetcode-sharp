namespace leetcode_sharp;

// 187. Repeated DNA Sequences
// https://leetcode.com/problems/repeated-dna-sequences
public class S00187
{
    public IList<string> FindRepeatedDnaSequences(string s)
    {
        const int sequenceLength = 10;

        if (s.Length < sequenceLength)
        {
            return [];
        }

        var dictionary = new Dictionary<string, int>();

        for (var i = 0; i <= s.Length - sequenceLength; i++)
        {
            var sub = s.Substring(i, sequenceLength);
            dictionary[sub] = dictionary.GetValueOrDefault(sub) + 1;
        }

        return dictionary.Where(pair => pair.Value > 1).Select(x => x.Key).ToList();
    }
}
