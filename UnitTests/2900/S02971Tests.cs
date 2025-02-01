using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02971Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02971();
        Assert.That(sut.LargestPerimeter([5, 5, 5]), Is.EqualTo(15));
    }

    [Test]
    public void T2()
    {
        var sut = new S02971();
        Assert.That(sut.LargestPerimeter([1, 12, 1, 2, 5, 50, 3]), Is.EqualTo(12));
    }

    [Test]
    public void T3()
    {
        var sut = new S02971();
        Assert.That(sut.LargestPerimeter([5, 5, 50]), Is.EqualTo(-1));
    }
}