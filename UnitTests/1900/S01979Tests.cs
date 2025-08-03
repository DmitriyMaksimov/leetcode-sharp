using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01979Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01979();
        Assert.That(sut.FindGCD([2, 5, 6, 9, 10]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01979();
        Assert.That(sut.FindGCD([7, 5, 6, 8, 3]), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S01979();
        Assert.That(sut.FindGCD([3, 3]), Is.EqualTo(3));
    }
}