using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02441Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02441();
        Assert.That(sut.FindMaxK([-1, 2, -3, 3]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S02441();
        Assert.That(sut.FindMaxK([-1, 10, 6, 7, -7, 1]), Is.EqualTo(7));
    }

    [Test]
    public void T3()
    {
        var sut = new S02441();
        Assert.That(sut.FindMaxK([-10, 8, 6, 7, -2, -3]), Is.EqualTo(-1));
    }
}