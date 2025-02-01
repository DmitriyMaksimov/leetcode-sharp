using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01403Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01403();
        Assert.That(sut.MinSubsequence(new[] {4, 3, 10, 9, 8}), Is.EqualTo((int[]) [10, 9]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01403();
        Assert.That(sut.MinSubsequence(new[] {4, 4, 7, 6, 7}), Is.EqualTo((int[]) [7, 7, 6]));
    }
}