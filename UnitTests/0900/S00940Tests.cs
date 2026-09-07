using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S00940))]
public class S00940Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00940();
        Assert.That(sut.DistinctSubseqII("aba"), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S00940();
        Assert.That(sut.DistinctSubseqII("abc"), Is.EqualTo(7));
    }

    [Test]
    public void T3()
    {
        var sut = new S00940();
        Assert.That(sut.DistinctSubseqII("aaa"), Is.EqualTo(3));
    }
}