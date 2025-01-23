namespace leetcode_sharp;

// 299. Bulls and Cows
// https://leetcode.com/problems/bulls-and-cows
public class S00299
{
    public string GetHint(string secret, string guess)
    {
        var bulls = 0;
        var cows = 0;
        var numbers = new int[10];

        for (var i = 0; i < secret.Length; i++)
        {
            var secretDigit = secret[i] - '0';
            var guessDigit = guess[i] - '0';

            if (secretDigit == guessDigit)
            {
                bulls++;
            }
            else
            {
                if (numbers[secretDigit] < 0)
                {
                    cows++;
                }

                if (numbers[guessDigit] > 0)
                {
                    cows++;
                }

                numbers[secretDigit]++;
                numbers[guessDigit]--;
            }
        }

        return $"{bulls}A{cows}B";
    }
}
