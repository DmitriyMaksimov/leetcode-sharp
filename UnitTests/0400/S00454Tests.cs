using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00454Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00454();
        Assert.That(sut.FourSumCount([1, 2], [-2, -1], [-1, 2], [0, 2]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00454();
        Assert.That(sut.FourSumCount([0], [0], [0], [0]), Is.EqualTo(1));
    }
}
