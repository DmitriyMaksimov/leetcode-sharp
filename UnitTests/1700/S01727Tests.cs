using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01727Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01727();
        Assert.That(sut.LargestSubmatrix(new[] {new[] {0, 0, 1}, new[] {1, 1, 1}, new[] {1, 0, 1}}), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S01727();
        Assert.That(sut.LargestSubmatrix(new[] {new[] {1, 0, 1, 0, 1}}), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S01727();
        Assert.That(sut.LargestSubmatrix(new[] {new[] {1, 1, 0}, new[] {1, 0, 1}}), Is.EqualTo(2));
    }
}