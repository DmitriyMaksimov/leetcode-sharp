using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01326Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01326();
        Assert.That(sut.MinTaps(5, new[] {3, 4, 1, 1, 0, 0}), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S01326();
        Assert.That(sut.MinTaps(3, new[] {0, 0, 0, 0}), Is.EqualTo(-1));
    }
}