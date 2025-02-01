using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02465Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02465();
        Assert.That(sut.DistinctAverages(new[] {4, 1, 4, 0, 3, 5}), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02465();
        Assert.That(sut.DistinctAverages(new[] {1, 100}), Is.EqualTo(1));
    }
}