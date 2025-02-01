using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01005Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01005();
        Assert.That(sut.LargestSumAfterKNegations(new[] {4, 2, 3}, 1), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S01005();
        Assert.That(sut.LargestSumAfterKNegations(new[] {3, -1, 0, 2}, 3), Is.EqualTo(6));
    }

    [Test]
    public void T3()
    {
        var sut = new S01005();
        Assert.That(sut.LargestSumAfterKNegations(new[] {2, -3, -1, 5, -4}, 2), Is.EqualTo(13));
    }
}