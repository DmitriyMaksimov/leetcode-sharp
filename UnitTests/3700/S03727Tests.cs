using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03727))]
public class S03727Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03727();
        Assert.That(sut.MaxAlternatingSum([1, 2, 3]), Is.EqualTo(12));
    }

    [Test]
    public void T2()
    {
        var sut = new S03727();
        Assert.That(sut.MaxAlternatingSum([1, -1, 2, -2, 3, -3]), Is.EqualTo(16));
    }

    [Test]
    public void T3()
    {
        var sut = new S03727();
        Assert.That(sut.MaxAlternatingSum([19, -20]), Is.EqualTo(39));
    }

    [Test]
    public void T4()
    {
        var sut = new S03727();
        Assert.That(sut.MaxAlternatingSum([6, 18, -15, -5]), Is.EqualTo(488));
    }
}