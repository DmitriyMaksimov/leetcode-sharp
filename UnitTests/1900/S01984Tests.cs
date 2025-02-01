using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01984Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01984();
        Assert.That(sut.MinimumDifference(new[] {90}, 1), Is.EqualTo(0));
    }

    [Test]
    public void T2()
    {
        var sut = new S01984();
        Assert.That(sut.MinimumDifference(new[] {9, 4, 1, 7}, 2), Is.EqualTo(2));
    }
}