using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03871))]
public class S03871Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03871();
        Assert.That(sut.CountCommas(1002), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S03871();
        Assert.That(sut.CountCommas(998), Is.Zero);
    }
}