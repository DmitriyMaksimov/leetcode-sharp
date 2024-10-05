using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02043Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02043.Bank([10, 100, 20, 50, 30]);
        sut.Withdraw(3, 10).Should().BeTrue(); // return true, account 3 has a balance of $20, so it is valid to withdraw $10.
        // Account 3 has $20 - $10 = $10.
        sut.Transfer(5, 1, 20).Should().BeTrue(); // return true, account 5 has a balance of $30, so it is valid to transfer $20.
        // Account 5 has $30 - $20 = $10, and account 1 has $10 + $20 = $30.
        sut.Deposit(5, 20).Should().BeTrue(); // return true, it is valid to deposit $20 to account 5.
        // Account 5 has $10 + $20 = $30.
        sut.Transfer(3, 4, 15).Should().BeFalse(); // return false, the current balance of account 3 is $10,
        // so it is invalid to transfer $15 from it.
        sut.Withdraw(10, 50).Should().BeFalse(); // return false, it is invalid because account 10 does not exist.
    }

    [Test]
    public void T2()
    {
        var sut = new S02043.Bank([
            767, 653, 252, 849, 480, 187, 761, 243, 408, 385, 334, 732, 289, 886, 149, 320, 827, 111, 315, 155, 695, 110, 473, 585, 83, 936, 188, 818, 33, 984, 66, 549, 954, 761,
            662, 212, 208, 215, 251, 792, 956, 261, 863, 374, 411, 639, 599, 418, 909, 208, 984, 602, 741, 302, 911, 616, 537, 422, 61, 746, 206, 396, 446, 661, 48, 156, 725, 662,
            422, 624, 704, 143, 94, 702, 126, 76, 539, 83, 270, 717, 736, 393, 607, 895, 661
        ]);
        sut.Deposit(68, 668).Should().BeTrue();
        sut.Deposit(25, 978).Should().BeTrue();
        sut.Transfer(8, 31, 924).Should().BeFalse();
        sut.Transfer(2, 6, 857).Should().BeFalse();
        sut.Transfer(20, 43, 59).Should().BeTrue();
        sut.Deposit(71, 307).Should().BeTrue();
        sut.Transfer(11, 46, 577).Should().BeFalse();
        sut.Withdraw(37, 377).Should().BeFalse();
        sut.Deposit(72, 835).Should().BeTrue();
        sut.Withdraw(82, 574).Should().BeFalse();
        sut.Transfer(67, 9, 939).Should().BeFalse();
        sut.Transfer(24, 49, 251).Should().BeTrue();
    }
}
