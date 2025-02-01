using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02828Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02828();
        Assert.That(sut.IsAcronym(new List<string> {"alice", "bob", "charlie"}, "abc"), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S02828();
        Assert.That(sut.IsAcronym(new List<string> {"an", "apple"}, "a"), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S02828();
        Assert.That(sut.IsAcronym(new List<string> {"never", "gonna", "give", "up", "on", "you"}, "ngguoy"), Is.True);
    }

    [Test]
    public void T4()
    {
        var sut = new S02828();
        Assert.That(sut.IsAcronym(new List<string> {"a", "b", "c"}, "abcd"), Is.False);
    }
}
