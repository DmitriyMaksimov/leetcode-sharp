using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01888))]
public class S01888Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01888();
        Assert.That(sut.MinFlips("111000"), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01888();
        Assert.That(sut.MinFlips("010"), Is.Zero);
    }

    [Test]
    public void T3()
    {
        var sut = new S01888();
        Assert.That(sut.MinFlips("1110"), Is.EqualTo(1));
    }
}