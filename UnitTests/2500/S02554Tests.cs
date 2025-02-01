using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02554Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02554();
        Assert.That(sut.MaxCount([1, 6, 5], 5, 6), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02554();
        Assert.That(sut.MaxCount([1, 2, 3, 4, 5, 6, 7], 8, 1), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S02554();
        Assert.That(sut.MaxCount([11], 7, 50), Is.EqualTo(7));
    }
}
