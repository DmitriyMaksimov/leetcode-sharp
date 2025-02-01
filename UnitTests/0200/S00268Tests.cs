using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00268Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00268();
        Assert.That(sut.MissingNumber(new[] {3, 0, 1}), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00268();
        Assert.That(sut.MissingNumber(new[] {0, 1}), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S00268();
        Assert.That(sut.MissingNumber(new[] {9, 6, 4, 2, 3, 5, 7, 0, 1}), Is.EqualTo(8));
    }
}