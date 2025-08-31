using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01015))]
public class S01015Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01015();
        Assert.That(sut.SmallestRepunitDivByK(1), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S01015();
        Assert.That(sut.SmallestRepunitDivByK(2), Is.EqualTo(-1));
    }

    [Test]
    public void T3()
    {
        var sut = new S01015();
        Assert.That(sut.SmallestRepunitDivByK(3), Is.EqualTo(3));
    }
}