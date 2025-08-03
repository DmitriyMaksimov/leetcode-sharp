using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02256Tests
{
    [Test]
    public void Test1()
    {
        var sut = new S02256();
        Assert.That(sut.MinimumAverageDifference([2, 5, 3, 9, 5, 3]), Is.EqualTo(3));
    }

    [Test]
    public void Test2()
    {
        var sut = new S02256();
        Assert.That(sut.MinimumAverageDifference([0]), Is.EqualTo(0));
    }

    [Test]
    public void Test3()
    {
        var sut = new S02256();
        Assert.That(sut.MinimumAverageDifference([1, 2, 3, 4, 5]), Is.EqualTo(0));
    }
}