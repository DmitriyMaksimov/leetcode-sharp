namespace leetcode_sharp;

// 929. Unique Email Addresses
// https://leetcode.com/problems/unique-email-addresses/
public class S00929
{
    public int NumUniqueEmails(string[] emails)
    {
        var set = new HashSet<string>();

        foreach (var email in emails)
        {
            var parts = email.Split('@');
            var localName = parts[0].Split('+')[0].Replace(".", "");
            set.Add($"{localName}@{parts[1]}");
        }

        return set.Count;
    }
}