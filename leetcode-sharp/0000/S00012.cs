namespace leetcode_sharp;

// 12. Integer to Roman
// https://leetcode.com/problems/integer-to-roman/
public class S00012
{
    public string IntToRoman(int num)
    {
        var retVal = "";
        var thousands = num / 1000;
        if (thousands > 0)
        {
            retVal += new string('M', thousands);
            num %= 1000;
        }

        var hundreds = num / 100;
        if (hundreds > 0)
        {
            retVal += hundreds switch
            {
                9 => "CM",
                8 => "DCCC",
                7 => "DCC",
                6 => "DC",
                5 => "D",
                4 => "CD",
                _ => new string('C', hundreds)
            };

            num %= 100;
        }

        var tens = num / 10;
        if (tens > 0)
        {
            retVal += tens switch
            {
                9 => "XC",
                8 => "LXXX",
                7 => "LXX",
                6 => "LX",
                5 => "L",
                4 => "XL",
                _ => new string('X', tens)
            };

            num %= 10;
        }

        var ones = num;
        if (ones > 0)
        {
            retVal += ones switch
            {
                9 => "IX",
                8 => "VIII",
                7 => "VII",
                6 => "VI",
                5 => "V",
                4 => "IV",
                _ => new string('I', ones)
            };
        }

        return retVal;
    }
}