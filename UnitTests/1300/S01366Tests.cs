using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01366Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01366();
        Assert.That(sut.RankTeams(["ABC", "ACB", "ABC", "ACB", "ACB"]), Is.EqualTo("ACB"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01366();
        Assert.That(sut.RankTeams(["WXYZ", "XYZW"]), Is.EqualTo("XWYZ"));
    }

    [Test]
    public void T3()
    {
        var sut = new S01366();
        Assert.That(sut.RankTeams(["ZMNAGUEDSJYLBOPHRQICWFXTVK"]), Is.EqualTo("ZMNAGUEDSJYLBOPHRQICWFXTVK"));
    }
}
