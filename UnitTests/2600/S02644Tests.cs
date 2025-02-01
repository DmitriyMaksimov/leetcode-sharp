using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02644Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02644();
        Assert.That(sut.MaxDivScore(new[] {4, 7, 9, 3, 9}, new[] {5, 2, 3}), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S02644();
        Assert.That(sut.MaxDivScore(new[] {20, 14, 21, 10}, new[] {5, 7, 5}), Is.EqualTo(5));
    }

    [Test]
    public void T3()
    {
        var sut = new S02644();
        Assert.That(sut.MaxDivScore(new[] {12}, new[] {10, 16}), Is.EqualTo(10));
    }
}