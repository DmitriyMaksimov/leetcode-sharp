using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02099Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02099();
        Assert.That(sut.MaxSubsequence([2, 1, 3, 3], 2), Is.EqualTo((int[]) [3, 3]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02099();
        Assert.That(sut.MaxSubsequence([-1, -2, 3, 4], 3), Is.EqualTo((int[]) [-1, 3, 4]));
    }

    [Test]
    public void T3()
    {
        var sut = new S02099();
        Assert.That(sut.MaxSubsequence([3, 4, 3, 3], 2), Is.EqualTo((int[]) [3, 4]));
    }
}