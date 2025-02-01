using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02563Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02563();
        Assert.That(sut.CountFairPairs([0, 1, 7, 4, 4, 5], 3, 6), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S02563();
        Assert.That(sut.CountFairPairs([1, 7, 9, 2, 5], 11, 11), Is.EqualTo(1));
    }
}
