namespace leetcode_sharp;

// 423. Reconstruct Original Digits from English
// https://leetcode.com/problems/reconstruct-original-digits-from-english
public class S00423
{
    public string OriginalDigits(string s)
    {
        var frequencies = new Dictionary<char, int>();

        foreach (var ch in s)
        {
            frequencies[ch] = frequencies.GetValueOrDefault(ch) + 1;
        }

        var words = new List<string> { "zero", "two", "four", "six", "eight", "one", "three", "five", "seven", "nine" };
        var correspondingDigits = new List<int> { 0, 2, 4, 6, 8, 1, 3, 5, 7, 9 };
        var counters = words.Select(digit => digit.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count())).ToList();

        var found = new int[10];

        for (var i = 0; i < counters.Count; i++)
        {
            var counter = counters[i];

            // Find the minimum k such that we can remove that many of the digit
            var k = counter.Keys.Select(x => frequencies.TryGetValue(x, out var value) ? value / counter[x] : 0).Min();

            foreach (var key in counter.Keys)
            {
                counter[key] *= k;
                if (frequencies.ContainsKey(key))
                {
                    frequencies[key] -= counter[key];
                }
            }

            found[correspondingDigits[i]] = k;
        }

        return string.Concat(Enumerable.Range(0, 10).SelectMany(i => Enumerable.Repeat(i.ToString(), found[i])));
    }
}
