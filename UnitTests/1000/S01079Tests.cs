using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01079Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01079();
        sut.NumTilePossibilities("AAB").Should().Be(8);
    }

    [Test]
    public void T2()
    {
        var sut = new S01079();
        sut.NumTilePossibilities("AAABBC").Should().Be(188);
    }

    [Test]
    public void T3()
    {
        var sut = new S01079();
        sut.NumTilePossibilities("V").Should().Be(1);
    }
}