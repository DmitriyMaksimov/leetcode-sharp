using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00852Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00852();
        Assert.That(sut.PeakIndexInMountainArray(new[] {0, 1, 0}), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S00852();
        Assert.That(sut.PeakIndexInMountainArray(new[] {0, 2, 1, 0}), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S00852();
        Assert.That(sut.PeakIndexInMountainArray(new[] {0, 10, 5, 2}), Is.EqualTo(1));
    }
}