namespace leetcode_sharp;

// 273. Integer to English Words
// https://leetcode.com/problems/integer-to-english-words
public class S00273
{
    private readonly string[] _belowTen = ["", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"];
    private readonly string[] _belowTwenty = ["Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"];
    private readonly string[] _belowHundred = ["", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"];

    private string NumberToEnglish(int num)
    {
        var result = num switch
        {
            < 10 => _belowTen[num],
            < 20 => _belowTwenty[num - 10],
            < 100 => _belowHundred[num / 10] + " " + NumberToEnglish(num % 10),
            < 1000 => NumberToEnglish(num / 100) + " Hundred " + NumberToEnglish(num % 100),
            < 1000000 => NumberToEnglish(num / 1000) + " Thousand " + NumberToEnglish(num % 1000),
            < 1000000000 => NumberToEnglish(num / 1000000) + " Million " + NumberToEnglish(num % 1000000),
            _ => NumberToEnglish(num / 1000000000) + " Billion " + NumberToEnglish(num % 1000000000)
        };

        return result.Trim();
    }

    public string NumberToWords(int num)
    {
        return num == 0 ? "Zero" : NumberToEnglish(num);
    }
}
