using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01838Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01838();
        Assert.That(sut.MaxFrequency(new[] {1, 2, 4}, 5), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S01838();
        Assert.That(sut.MaxFrequency(new[] {1, 4, 8, 13}, 5), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S01838();
        Assert.That(sut.MaxFrequency(new[] {3, 9, 6}, 2), Is.EqualTo(1));
    }
}