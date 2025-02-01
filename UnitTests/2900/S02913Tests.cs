using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02913Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02913();
        Assert.That(sut.SumCounts(new[] {1, 2, 1}), Is.EqualTo(15));
    }

    [Test]
    public void T2()
    {
        var sut = new S02913();
        Assert.That(sut.SumCounts(new[] {1, 1}), Is.EqualTo(3));
    }
}