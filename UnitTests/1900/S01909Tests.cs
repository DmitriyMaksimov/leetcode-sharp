using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01909Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01909();
        Assert.That(sut.CanBeIncreasing(new[] {1, 2, 10, 5, 7}), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01909();
        Assert.That(sut.CanBeIncreasing(new[] {2, 3, 1, 2}), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S01909();
        Assert.That(sut.CanBeIncreasing(new[] {1, 1, 1}), Is.False);
    }
}
