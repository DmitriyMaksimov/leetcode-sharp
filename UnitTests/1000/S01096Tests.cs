using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01096))]
public class S01096Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01096();
        Assert.That(sut.BraceExpansionII("{a,b}{c,{d,e}}"), Is.EqualTo(["ac", "ad", "ae", "bc", "bd", "be"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01096();
        Assert.That(sut.BraceExpansionII("{{a,z},a{b,c},{ab,z}}"), Is.EqualTo(["a", "ab", "ac", "z"]));
    }
}