namespace leetcode_sharp;

// 784. Letter Case Permutation
// https://leetcode.com/problems/letter-case-permutation/
public class S00784
{
    public IList<string> LetterCasePermutation(string s)
    {
        var result = new List<string>();
        var arr = s.ToCharArray();
        var numberOfLetters = 0;
        var indicesOfLetters = new List<int>();

        for (var i = 0; i < arr.Length; i++)
        {
            if (char.IsLetter(arr[i]))
            {
                indicesOfLetters.Add(i);
                ++numberOfLetters;
            }
        }

        var numberOfVariants = (int)Math.Pow(2, numberOfLetters);
        
        for (var bitMask = 0; bitMask < numberOfVariants; bitMask++)
        {
            var mask = 1;
            for (var bit = 0; bit < numberOfLetters; bit++)
            {
                if ((bitMask & mask) != 0)
                {
                    arr[indicesOfLetters[bit]] = char.ToLower(arr[indicesOfLetters[bit]]);
                }
                else
                {
                    arr[indicesOfLetters[bit]] = char.ToUpper(arr[indicesOfLetters[bit]]);
                }

                mask <<= 1;
            }
            
            result.Add(new string(arr));
        }
        
        return result;
    }
}