using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00367Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00367();
        Assert.That(sut.IsPerfectSquare(16), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00367();
        Assert.That(sut.IsPerfectSquare(14), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S00367();
        Assert.That(sut.IsPerfectSquare(1), Is.True);
    }

    [Test]
    public void T4()
    {
        var sut = new S00367();
        Assert.That(sut.IsPerfectSquare(4), Is.True);
    }

    [Test]
    public void T5()
    {
        var sut = new S00367();
        Assert.That(sut.IsPerfectSquare(2147483647), Is.False);
    }
}
