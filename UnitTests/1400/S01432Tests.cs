using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01432))]
public class S01432Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01432();
        Assert.That(sut.MaxDiff(555), Is.EqualTo(888));
    }

    [Test]
    public void T2()
    {
        var sut = new S01432();
        Assert.That(sut.MaxDiff(9), Is.EqualTo(8));
    }
}