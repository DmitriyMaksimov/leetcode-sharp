using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01806Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01806();
        Assert.That(sut.ReinitializePermutation(2), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S01806();
        Assert.That(sut.ReinitializePermutation(4), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S01806();
        Assert.That(sut.ReinitializePermutation(6), Is.EqualTo(4));
    }
}