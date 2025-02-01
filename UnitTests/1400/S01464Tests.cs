using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01464Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01464();
        Assert.That(sut.MaxProduct(new[] {3, 4, 5, 2}), Is.EqualTo(12));
    }

    [Test]
    public void T2()
    {
        var sut = new S01464();
        Assert.That(sut.MaxProduct(new[] {1, 5, 4, 5}), Is.EqualTo(16));
    }

    [Test]
    public void T3()
    {
        var sut = new S01464();
        Assert.That(sut.MaxProduct(new[] {3, 7}), Is.EqualTo(12));
    }
}