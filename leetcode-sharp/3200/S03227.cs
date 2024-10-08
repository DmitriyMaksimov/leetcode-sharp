namespace leetcode_sharp;

// 3227. Vowels Game in a String
// https://leetcode.com/problems/vowels-game-in-a-string
public class S03227
{
    public bool DoesAliceWin(string s)
    {
        return s.Any(ch => ch is 'a' or 'e' or 'i' or 'o' or 'u');
    }
}
