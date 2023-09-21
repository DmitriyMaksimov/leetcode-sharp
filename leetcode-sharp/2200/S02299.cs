namespace leetcode_sharp;

// 2299. Strong Password Checker II
// https://leetcode.com/problems/strong-password-checker-ii/
public class S02299
{
    public bool StrongPasswordCheckerII(string password)
    {
        if (password.Length < 8)
        {
            return false;
        }

        var hasLower = false;
        var hasUpper = false;
        var hasDigit = false;
        var hasSpecial = false;
        var prev = ' ';

        foreach (var c in password)
        {
            if (!hasLower && char.IsLower(c))
            {
                hasLower = true;
            }
            else if (!hasUpper && char.IsUpper(c))
            {
                hasUpper = true;
            }
            else if (prev != ' ' && prev == c)
            {
                return false;
            }
            else if (!hasDigit && char.IsDigit(c))
            {
                hasDigit = true;
            }
            else if (!hasSpecial && "!@#$%^&*()-+".Contains(c))
            {
                hasSpecial = true;
            }

            prev = c;
        }

        return hasLower && hasUpper && hasDigit && hasSpecial;
    }
}