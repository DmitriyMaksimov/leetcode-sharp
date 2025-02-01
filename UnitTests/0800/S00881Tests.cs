using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00881Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00881();
        Assert.That(sut.NumRescueBoats(new[] {1, 2}, 3), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S00881();
        Assert.That(sut.NumRescueBoats(new[] {3, 2, 2, 1}, 3), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S00881();
        Assert.That(sut.NumRescueBoats(new[] {3, 5, 3, 4}, 5), Is.EqualTo(4));
    }
}