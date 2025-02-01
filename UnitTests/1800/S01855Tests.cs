using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01855Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01855();
        Assert.That(sut.MaxDistance(new[] {55, 30, 5, 4, 2}, new[] {100, 20, 10, 10, 5}), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01855();
        Assert.That(sut.MaxDistance(new[] {2, 2, 2}, new[] {10, 10, 1}), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S01855();
        Assert.That(sut.MaxDistance(new[] {30, 29, 19, 5}, new[] {25, 25, 25, 25, 25}), Is.EqualTo(2));
    }
}