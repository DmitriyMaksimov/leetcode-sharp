using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01366Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01366();
        sut.RankTeams(["ABC", "ACB", "ABC", "ACB", "ACB"]).Should().Be("ACB");
    }

    [Test]
    public void T2()
    {
        var sut = new S01366();
        sut.RankTeams(["WXYZ", "XYZW"]).Should().Be("XWYZ");
    }

    [Test]
    public void T3()
    {
        var sut = new S01366();
        sut.RankTeams(["ZMNAGUEDSJYLBOPHRQICWFXTVK"]).Should().Be("ZMNAGUEDSJYLBOPHRQICWFXTVK");
    }
}
