using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00813Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00813();
        Assert.That(sut.LargestSumOfAverages([9, 1, 2, 3, 9], 3), Is.EqualTo(20).Within(0.000001));
    }

    [Test]
    public void T2()
    {
        var sut = new S00813();
        Assert.That(sut.LargestSumOfAverages([1, 2, 3, 4, 5, 6, 7], 4), Is.EqualTo(20.5).Within(0.000001));
    }
}
