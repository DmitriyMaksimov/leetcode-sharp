using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00367Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00367();
        sut.IsPerfectSquare(16).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S00367();
        sut.IsPerfectSquare(14).Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S00367();
        sut.IsPerfectSquare(1).Should().BeTrue();
    }

    [Test]
    public void T4()
    {
        var sut = new S00367();
        sut.IsPerfectSquare(4).Should().BeTrue();
    }

    [Test]
    public void T5()
    {
        var sut = new S00367();
        sut.IsPerfectSquare(2147483647).Should().BeFalse();
    }
}