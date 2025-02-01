using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01079Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01079();
        Assert.That(sut.NumTilePossibilities("AAB"), Is.EqualTo(8));
    }

    [Test]
    public void T2()
    {
        var sut = new S01079();
        Assert.That(sut.NumTilePossibilities("AAABBC"), Is.EqualTo(188));
    }

    [Test]
    public void T3()
    {
        var sut = new S01079();
        Assert.That(sut.NumTilePossibilities("V"), Is.EqualTo(1));
    }
}