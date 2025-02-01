using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03105Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03105();
        Assert.That(sut.LongestMonotonicSubarray([1, 4, 3, 3, 2]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S03105();
        Assert.That(sut.LongestMonotonicSubarray([3, 3, 3, 3]), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S03105();
        Assert.That(sut.LongestMonotonicSubarray([3, 2, 1]), Is.EqualTo(3));
    }
}