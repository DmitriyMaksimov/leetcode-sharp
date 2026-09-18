using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01520))]
public class S01520Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01520();
        Assert.That(sut.MaxNumOfSubstrings("adefaddaccc"), Is.EquivalentTo(["e", "f", "ccc"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01520();
        Assert.That(sut.MaxNumOfSubstrings("abbaccd"), Is.EquivalentTo(["d", "bb", "cc"]));
    }
}