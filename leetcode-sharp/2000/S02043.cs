namespace leetcode_sharp;

// 2043. Simple Bank System
// https://leetcode.com/problems/simple-bank-system
public class S02043
{
    public class Bank
    {
        private readonly long[] _balance;

        public Bank(long[] balance)
        {
            _balance = balance;
        }

        public bool Transfer(int account1, int account2, long money)
        {
            if (!IsValidAccount(account1) || !IsValidAccount(account2) || _balance[account1 - 1] < money)
            {
                return false;
            }

            Withdraw(account1, money);
            Deposit(account2, money);

            return true;
        }

        public bool Deposit(int account, long money)
        {
            if (!IsValidAccount(account))
            {
                return false;
            }

            _balance[account - 1] += money;

            return true;
        }

        public bool Withdraw(int account, long money)
        {
            if (!IsValidAccount(account) || _balance[account - 1] < money)
            {
                return false;
            }

            _balance[account - 1] -= money;

            return true;
        }

        private bool IsValidAccount(int account)
        {
            return account > 0 && account <= _balance.Length;
        }
    }
}
