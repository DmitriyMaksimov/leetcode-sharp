using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00997Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00997();
        Assert.That(sut.FindJudge(2, new[] {new[] {1, 2}}), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00997();
        Assert.That(sut.FindJudge(3, new[] {new[] {1, 3}, new[] {2, 3}}), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S00997();
        Assert.That(sut.FindJudge(3, new[] {new[] {1, 3}, new[] {2, 3}, new[] {3, 1}}), Is.EqualTo(-1));
    }
}