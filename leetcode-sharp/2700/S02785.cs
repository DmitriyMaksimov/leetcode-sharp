namespace leetcode_sharp;

// 2785. Sort Vowels in a String
// https://leetcode.com/problems/sort-vowels-in-a-string
public class S02785
{
    public string SortVowels(string s)
    {
        var vowels = new HashSet<char> {'a', 'e', 'i', 'o', 'u','A', 'E', 'I', 'O', 'U' };
        var charArray = s.ToCharArray();
        var vowelsFromString = new List<char>();
        var vowelIndices = new List<int>();
        
        for (var i = 0; i < charArray.Length; i++)
        {
            if (vowels.Contains(charArray[i]))
            {
                vowelsFromString.Add(charArray[i]);
                vowelIndices.Add(i);
            }
        }

        vowelsFromString = vowelsFromString.OrderBy(x => x).ToList();
        
        for (var i = 0; i < vowelIndices.Count; i++)
        {
            charArray[vowelIndices[i]] = vowelsFromString[i];
        }
        
        return new string(charArray);
    }
}