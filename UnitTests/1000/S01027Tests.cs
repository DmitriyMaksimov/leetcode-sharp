using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01027Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01027();
        Assert.That(sut.LongestArithSeqLength(new[] {3, 6, 9, 12}), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S01027();
        Assert.That(sut.LongestArithSeqLength(new[] {9, 4, 7, 2, 10}), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S01027();
        Assert.That(sut.LongestArithSeqLength(new[] {20, 1, 15, 3, 10, 5, 8}), Is.EqualTo(4));
    }
}