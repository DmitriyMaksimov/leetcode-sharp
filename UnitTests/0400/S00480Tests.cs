using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S00480))]
public class S00480Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00480();
        Assert.That(sut.MedianSlidingWindow([1, 3, -1, -3, 5, 3, 6, 7], 3), Is.EqualTo([1.00000, -1.00000, -1.00000, 3.00000, 5.00000, 6.00000]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00480();
        Assert.That(sut.MedianSlidingWindow([1, 2, 3, 4, 2, 3, 1, 4, 2], 3), Is.EqualTo([2.00000, 3.00000, 3.00000, 3.00000, 2.00000, 3.00000, 2.00000]));
    }

    [Test]
    public void T3()
    {
        var sut = new S00480();
        Assert.That(sut.MedianSlidingWindow([2147483647, 2147483647], 2), Is.EqualTo([2147483647.00000]));
    }
}