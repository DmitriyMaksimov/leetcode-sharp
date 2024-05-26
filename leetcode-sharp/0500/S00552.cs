namespace leetcode_sharp;

// 552. Student Attendance Record II
// https://leetcode.com/problems/student-attendance-record-ii
public class S00552
{
    private const int Mod = 1_000_000_000 + 7;

    public int CheckRecord(int n)
    {
        if (n == 1) return 3;
        if (n == 2) return 8;

        var absent = new int [n];
        absent[0] = 1;
        absent[1] = 2;
        absent[2] = 4;
        
        var present = new int [n];
        present[0] = 1;

        var late = new int [n];
        late[0] = 1;
        late[1] = 3;


        for (var i = 1; i < n; i++)
        {
            absent[i - 1] %= Mod;
            present[i - 1] %= Mod;
            late[i - 1] %= Mod;

            present[i] = ((absent[i - 1] + present[i - 1]) % Mod + late[i - 1]) % Mod;

            if (i > 1)
            {
                late[i] = ((absent[i - 1] + present[i - 1]) % Mod + (absent[i - 2] + present[i - 2]) % Mod) % Mod;
            }

            if (i > 2)
            {
                absent[i] = ((absent[i - 1] + absent[i - 2]) % Mod + absent[i - 3]) % Mod;
            }
        }

        return ((absent[n - 1] % Mod + present[n - 1] % Mod) % Mod + late[n - 1] % Mod) % Mod;
    }
}