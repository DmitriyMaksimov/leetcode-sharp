using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00756Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00756();
        Assert.That(sut.PyramidTransition("BCD", ["BCC", "CDE", "CEA", "FFF"]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00756();
        Assert.That(sut.PyramidTransition("AAAA", ["AAB", "AAC", "BCD", "BBE", "DEF"]), Is.False);
    }
}
