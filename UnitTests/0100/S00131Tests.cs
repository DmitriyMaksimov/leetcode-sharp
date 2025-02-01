using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00131Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00131();
        Assert.That(sut.Partition("aab"), Is.EquivalentTo(new[] {new[] {"a", "a", "b"}, new[] {"aa", "b"}}));
    }

    [Test]
    public void T2()
    {
        var sut = new S00131();
        Assert.That(sut.Partition("a"), Is.EquivalentTo(new[] {new[] {"a"}}));
    }

    [Test]
    public void T3()
    {
        var sut = new S00131();
        Assert.That(sut.Partition("bb"), Is.EquivalentTo(new[] {new[] {"bb"}, new []{"b", "b"}}));
    }
}