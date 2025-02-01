using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01362Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01362();
        Assert.That(sut.ClosestDivisors(8), Is.EqualTo((int[]) [3, 3]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01362();
        Assert.That(sut.ClosestDivisors(123), Is.EqualTo((int[]) [5, 25]));
    }

    [Test]
    public void T3()
    {
        var sut = new S01362();
        Assert.That(sut.ClosestDivisors(999), Is.EqualTo((int[]) [25, 40]));
    }
}
