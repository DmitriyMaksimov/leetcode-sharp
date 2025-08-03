using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01725Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01725();
        Assert.That(sut.CountGoodRectangles([[5, 8], [3, 9], [5, 12], [16, 5]]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S01725();
        Assert.That(sut.CountGoodRectangles([[2, 3], [3, 7], [4, 3], [3, 7]]), Is.EqualTo(3));
    }
}