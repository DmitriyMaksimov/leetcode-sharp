using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00959Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00959();
        Assert.That(sut.RegionsBySlashes([" /", "/ "]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00959();
        Assert.That(sut.RegionsBySlashes([" /", "  "]), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S00959();
        Assert.That(sut.RegionsBySlashes(["/\\", "\\/"]), Is.EqualTo(5));
    }
}
