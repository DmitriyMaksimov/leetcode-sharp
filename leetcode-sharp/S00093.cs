namespace leetcode_sharp;

// 93. Restore IP Addresses
// https://leetcode.com/problems/restore-ip-addresses/
public class S00093
{
    public IList<string> RestoreIpAddresses(string s)
    {
        var result = new List<string>();

        if (s.Length > 12)
        {
            return result;
        }

        for (var i1 = 1; i1 <= 3; i1++)
        {
            for (var i2 = 1; i2 <= 3; i2++)
            {
                for (var i3 = 1; i3 <= 3; i3++)
                {
                    if (i1 + i2 + i3 >= s.Length)
                    {
                        continue;
                    }
                    
                    var s1 = s.Substring(0, i1);
                    var s2 = s.Substring(i1, i2);
                    var s3 = s.Substring(i1 + i2, i3);
                    var s4 = s.Substring(i1 + i2 + i3);

                    if (isValidOctet(s1) && isValidOctet(s2) && isValidOctet(s3) && isValidOctet(s4))
                    {
                        result.Add($"{s1}.{s2}.{s3}.{s4}");
                    }
                }
            }
        }
        
        return result;
    }

    private static bool isValidOctet(string s)
    {
        switch (s.Length)
        {
            case > 3:
            case > 1 when s[0] == '0':
                return false;
        }

        return int.Parse(s) <= 255;
    }
}